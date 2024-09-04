import numpy as np
from PIL import Image, ImageEnhance, ImageTk
import tkinter as tk
from tkinter import filedialog, ttk
import pickle
import matplotlib.pyplot as plt
from matplotlib.backends.backend_tkagg import FigureCanvasTkAgg

class HopfieldNetwork:
    def __init__(self, size):
        self.size = size
        self.weights = np.zeros((size, size))

    def train(self, patterns):
        for pattern in patterns:
            flat = pattern.flatten()
            self.weights += np.outer(flat, flat)
        np.fill_diagonal(self.weights, 0)
        self.weights /= self.size

    def update(self, state):
        return np.sign(self.weights @ state)

    def energy(self, state):
        return -0.5 * state @ self.weights @ state

    def recognize(self, pattern, max_iterations=100):
        state = pattern.flatten()
        energies = []
        for _ in range(max_iterations):
            new_state = self.update(state)
            energies.append(self.energy(new_state))
            if np.array_equal(new_state, state):
                break
            state = new_state
        return state.reshape(pattern.shape), energies

def load_image(path, size=(32, 32), enhance_contrast=1.0, enhance_brightness=1.0, enhance_sharpness=1.0):
    img = Image.open(path).convert('L').resize(size)
    img = ImageEnhance.Contrast(img).enhance(enhance_contrast)
    img = ImageEnhance.Brightness(img).enhance(enhance_brightness)
    img = ImageEnhance.Sharpness(img).enhance(enhance_sharpness)
    return np.array(img) / 255.0 > 0.5

def save_image(array, path):
    img = Image.fromarray((array * 255).astype(np.uint8))
    img.save(path)

class Application(tk.Frame):
    def __init__(self, master=None):
        super().__init__(master)
        self.master = master
        self.master.title("Sistema de Reconocimiento de Imágenes con Red de Hopfield")
        self.pack(fill=tk.BOTH, expand=True)
        self.create_widgets()
        self.network = HopfieldNetwork(32*32)
        self.patterns = []

    def create_widgets(self):
        self.control_frame = ttk.Frame(self)
        self.control_frame.pack(side=tk.LEFT, fill=tk.Y, padx=10, pady=10)

        self.image_frame = ttk.Frame(self)
        self.image_frame.pack(side=tk.LEFT, fill=tk.BOTH, expand=True, padx=10, pady=10)

        self.graph_frame = ttk.Frame(self)
        self.graph_frame.pack(side=tk.RIGHT, fill=tk.BOTH, expand=True, padx=10, pady=10)

        self.train_button = ttk.Button(self.control_frame, text="Entrenar Red", command=self.train_network)
        self.train_button.pack(fill=tk.X, pady=5)

        self.recognize_button = ttk.Button(self.control_frame, text="Reconocer Imagen", command=self.recognize_image)
        self.recognize_button.pack(fill=tk.X, pady=5)

        self.save_network_button = ttk.Button(self.control_frame, text="Guardar Red", command=self.save_network)
        self.save_network_button.pack(fill=tk.X, pady=5)

        self.load_network_button = ttk.Button(self.control_frame, text="Cargar Red", command=self.load_network)
        self.load_network_button.pack(fill=tk.X, pady=5)

        self.create_sliders()

        self.progress = ttk.Progressbar(self.control_frame, orient=tk.HORIZONTAL, length=200, mode='determinate')
        self.progress.pack(fill=tk.X, pady=5)

        self.quit = ttk.Button(self.control_frame, text="SALIR", command=self.master.destroy)
        self.quit.pack(fill=tk.X, pady=5)

        self.input_image_label = ttk.Label(self.image_frame, text="Imagen de entrada")
        self.input_image_label.pack()
        self.input_image = ttk.Label(self.image_frame)
        self.input_image.pack()

        self.output_image_label = ttk.Label(self.image_frame, text="Imagen reconocida")
        self.output_image_label.pack()
        self.output_image = ttk.Label(self.image_frame)
        self.output_image.pack()

        self.fig, self.ax = plt.subplots()
        self.canvas = FigureCanvasTkAgg(self.fig, master=self.graph_frame)
        self.canvas.draw()
        self.canvas.get_tk_widget().pack(fill=tk.BOTH, expand=True)

    def create_sliders(self):
        self.contrast_label = ttk.Label(self.control_frame, text="Contraste:")
        self.contrast_label.pack()
        self.contrast_scale = ttk.Scale(self.control_frame, from_=0.5, to=2.0, orient=tk.HORIZONTAL)
        self.contrast_scale.set(1.0)
        self.contrast_scale.pack(fill=tk.X)

        self.brightness_label = ttk.Label(self.control_frame, text="Brillo:")
        self.brightness_label.pack()
        self.brightness_scale = ttk.Scale(self.control_frame, from_=0.5, to=2.0, orient=tk.HORIZONTAL)
        self.brightness_scale.set(1.0)
        self.brightness_scale.pack(fill=tk.X)

        self.sharpness_label = ttk.Label(self.control_frame, text="Nitidez:")
        self.sharpness_label.pack()
        self.sharpness_scale = ttk.Scale(self.control_frame, from_=0.5, to=2.0, orient=tk.HORIZONTAL)
        self.sharpness_scale.set(1.0)
        self.sharpness_scale.pack(fill=tk.X)

    def train_network(self):
        file_paths = filedialog.askopenfilenames(title="Seleccionar imágenes para entrenamiento")
        self.patterns = []
        self.progress['value'] = 0
        self.progress['maximum'] = len(file_paths)
        for path in file_paths:
            img = load_image(path, 
                             enhance_contrast=self.contrast_scale.get(),
                             enhance_brightness=self.brightness_scale.get(),
                             enhance_sharpness=self.sharpness_scale.get())
            self.patterns.append(img)
            self.progress['value'] += 1
            self.update_idletasks()
        self.network.train(self.patterns)
        print("Red entrenada con éxito")

    def recognize_image(self):
        file_path = filedialog.askopenfilename(title="Seleccionar imagen para reconocer")
        input_image = load_image(file_path, 
                                 enhance_contrast=self.contrast_scale.get(),
                                 enhance_brightness=self.brightness_scale.get(),
                                 enhance_sharpness=self.sharpness_scale.get())
        self.display_image(input_image, self.input_image)
        recognized, energies = self.network.recognize(input_image)
        self.display_image(recognized, self.output_image)
        save_image(recognized, "recognized.png")
        print("Imagen reconocida guardada como 'recognized.png'")
        self.plot_energy(energies)

    def display_image(self, img_array, label):
        img = Image.fromarray((img_array * 255).astype(np.uint8))
        img = img.resize((200, 200), Image.NEAREST)
        photo = ImageTk.PhotoImage(img)
        label.config(image=photo)
        label.image = photo

    def plot_energy(self, energies):
        self.ax.clear()
        self.ax.plot(energies)
        self.ax.set_title('Evolución de la Energía')
        self.ax.set_xlabel('Iteraciones')
        self.ax.set_ylabel('Energía')
        self.canvas.draw()

    def save_network(self):
        file_path = filedialog.asksaveasfilename(defaultextension=".pkl")
        with open(file_path, 'wb') as f:
            pickle.dump(self.network, f)
        print("Red guardada con éxito")

    def load_network(self):
        file_path = filedialog.askopenfilename()
        with open(file_path, 'rb') as f:
            self.network = pickle.load(f)
        print("Red cargada con éxito")

root = tk.Tk()
app = Application(master=root)
app.mainloop()
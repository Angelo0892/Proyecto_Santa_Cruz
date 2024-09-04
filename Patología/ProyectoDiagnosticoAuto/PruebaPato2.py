import tkinter as tk
from tkinter import ttk, messagebox, scrolledtext
import numpy as np
import random

class Paciente:
    def __init__(self, id, edad, genero, sintomas, resultados_pruebas, antecedentes_familiares, habitos):
        self.id = id
        self.edad = edad
        self.genero = genero
        self.sintomas = sintomas
        self.resultados_pruebas = resultados_pruebas
        self.antecedentes_familiares = antecedentes_familiares
        self.habitos = habitos
        self.diagnostico = None
        self.tratamiento = None

class Cancer:
    def __init__(self, tipo, estadio):
        self.tipo = tipo
        self.estadio = estadio

class Tratamiento:
    def __init__(self, tipo, duracion, detalles):
        self.tipo = tipo
        self.duracion = duracion
        self.detalles = detalles

class SistemaExpertoOncologico:
    def __init__(self):
        self.base_conocimientos = self.cargar_base_conocimientos()

    def cargar_base_conocimientos(self):
        return {
            "cerebro": {
                1: Tratamiento("cirugia", "3 meses", "Resección del tumor con seguimiento"),
                2: Tratamiento("radioterapia + quimioterapia", "6 meses", "Temozolomida + Radioterapia"),
                3: Tratamiento("cirugia + radioterapia + quimioterapia", "9 meses", "Resección del tumor + Radioterapia + Temozolomida"),
                4: Tratamiento("terapia dirigida + cuidados paliativos", "indefinido", "Bevacizumab + Manejo de síntomas")
            }
        }

    def diagnosticar(self, paciente):
        tipos_cancer = ["cerebro"]
        estadios = [1, 2, 3, 4]
        tipo_cancer = random.choice(tipos_cancer)
        estadio = random.choice(estadios)
        return Cancer(tipo_cancer, estadio)

    def recomendar_tratamiento(self, cancer):
        return self.base_conocimientos.get(cancer.tipo, {}).get(cancer.estadio)

    def procesar_paciente(self, paciente):
        paciente.diagnostico = self.diagnosticar(paciente)
        if paciente.diagnostico:
            paciente.tratamiento = self.recomendar_tratamiento(paciente.diagnostico)
        return paciente

class InterfazGrafica:
    def __init__(self, master):
        self.master = master
        self.master.title("Sistema Experto Oncológico - Cerebro")
        self.master.geometry("700x800")
        self.master.configure(bg='#add8e6')
        self.sistema = SistemaExpertoOncologico()
        self.crear_widgets()

    def crear_widgets(self):
        # Logo
        logo = tk.PhotoImage(file="C:/Users/Isra Iss/Desktop/Ingenieria de Software I/Proyecto/Imagenes/logo.png")  # Reemplaza con la ruta de tu logo
        logo_label = tk.Label(self.master, image=logo, bg='#add8e6')
        logo_label.image = logo  # Guardar referencia para evitar que el logo sea eliminado por el garbage collector
        logo_label.pack(side=tk.LEFT, padx=10, pady=10)

        notebook = ttk.Notebook(self.master)
        notebook.pack(fill=tk.BOTH, expand=True, padx=10, pady=10)

        # Pestaña de Datos del Paciente
        frame_paciente = ttk.Frame(notebook)
        notebook.add(frame_paciente, text="Datos del Paciente")

        ttk.Label(frame_paciente, text="ID del Paciente:", background='#add8e6').grid(row=0, column=0, sticky="w", padx=5, pady=5)
        self.id_entry = ttk.Entry(frame_paciente)
        self.id_entry.grid(row=0, column=1, padx=5, pady=5)

        ttk.Label(frame_paciente, text="Edad:", background='#add8e6').grid(row=1, column=0, sticky="w", padx=5, pady=5)
        self.edad_entry = ttk.Entry(frame_paciente)
        self.edad_entry.grid(row=1, column=1, padx=5, pady=5)

        ttk.Label(frame_paciente, text="Género:", background='#add8e6').grid(row=2, column=0, sticky="w", padx=5, pady=5)
        self.genero_var = tk.StringVar()
        ttk.Radiobutton(frame_paciente, text="Masculino", variable=self.genero_var, value="masculino").grid(row=2, column=1, sticky="w", padx=5, pady=2)
        ttk.Radiobutton(frame_paciente, text="Femenino", variable=self.genero_var, value="femenino").grid(row=3, column=1, sticky="w", padx=5, pady=2)

        # Pestaña de Síntomas
        frame_sintomas = ttk.Frame(notebook)
        notebook.add(frame_sintomas, text="Síntomas")

        self.dolor_cabeza_var = tk.BooleanVar()
        self.perdida_memoria_var = tk.BooleanVar()
        self.convulsiones_var = tk.BooleanVar()
        self.dificultad_hablar_var = tk.BooleanVar()

        ttk.Checkbutton(frame_sintomas, text="Dolor de cabeza", variable=self.dolor_cabeza_var).grid(row=0, column=0, sticky="w", padx=5, pady=2)
        ttk.Checkbutton(frame_sintomas, text="Pérdida de memoria", variable=self.perdida_memoria_var).grid(row=1, column=0, sticky="w", padx=5, pady=2)
        ttk.Checkbutton(frame_sintomas, text="Convulsiones", variable=self.convulsiones_var).grid(row=2, column=0, sticky="w", padx=5, pady=2)
        ttk.Checkbutton(frame_sintomas, text="Dificultad para hablar", variable=self.dificultad_hablar_var).grid(row=3, column=0, sticky="w", padx=5, pady=2)

        # Pestaña de Resultados de Pruebas
        frame_pruebas = ttk.Frame(notebook)
        notebook.add(frame_pruebas, text="Resultados de Pruebas")

        ttk.Label(frame_pruebas, text="Tamaño del tumor (cm):", background='#add8e6').grid(row=0, column=0, sticky="w", padx=5, pady=5)
        self.tumor_entry = ttk.Entry(frame_pruebas)
        self.tumor_entry.grid(row=0, column=1, padx=5, pady=5)

        ttk.Label(frame_pruebas, text="Nivel marcador tumoral:", background='#add8e6').grid(row=1, column=0, sticky="w", padx=5, pady=5)
        self.marcador_entry = ttk.Entry(frame_pruebas)
        self.marcador_entry.grid(row=1, column=1, padx=5, pady=5)

        ttk.Label(frame_pruebas, text="Nivel de hemoglobina:", background='#add8e6').grid(row=2, column=0, sticky="w", padx=5, pady=5)
        self.hemoglobina_entry = ttk.Entry(frame_pruebas)
        self.hemoglobina_entry.grid(row=2, column=1, padx=5, pady=5)

        # Pestaña de Antecedentes y Hábitos
        frame_antecedentes = ttk.Frame(notebook)
        notebook.add(frame_antecedentes, text="Antecedentes y Hábitos")

        self.antecedentes_var = tk.BooleanVar()
        ttk.Checkbutton(frame_antecedentes, text="Antecedentes familiares de cáncer", variable=self.antecedentes_var).grid(row=0, column=0, sticky="w", padx=5, pady=2)

        self.tabaquismo_var = tk.BooleanVar()
        self.alcohol_var = tk.BooleanVar()
        ttk.Checkbutton(frame_antecedentes, text="Tabaquismo", variable=self.tabaquismo_var).grid(row=1, column=0, sticky="w", padx=5, pady=2)
        ttk.Checkbutton(frame_antecedentes, text="Consumo de alcohol", variable=self.alcohol_var).grid(row=2, column=0, sticky="w", padx=5, pady=2)

        # Botón de procesamiento
        ttk.Button(self.master, text="Procesar Paciente", command=self.procesar_paciente).pack(pady=10)

        # Área de resultados
        self.resultado_text = scrolledtext.ScrolledText(self.master, height=10, width=70)
        self.resultado_text.pack(padx=10, pady=10)

    def procesar_paciente(self):
        try:
            id = self.id_entry.get()
            edad = int(self.edad_entry.get())
            genero = self.genero_var.get()
            if not genero:
                raise ValueError("Por favor, seleccione un género.")
            
            sintomas = []
            if self.dolor_cabeza_var.get():
                sintomas.append("dolor de cabeza")
            if self.perdida_memoria_var.get():
                sintomas.append("pérdida de memoria")
            if self.convulsiones_var.get():
                sintomas.append("convulsiones")
            if self.dificultad_hablar_var.get():
                sintomas.append("dificultad para hablar")

            resultados_pruebas = {
                "tamaño_tumor": float(self.tumor_entry.get()),
                "marcador_tumoral": float(self.marcador_entry.get()),
                "hemoglobina": float(self.hemoglobina_entry.get())
            }

            antecedentes_familiares = self.antecedentes_var.get()
            habitos = {
                "tabaquismo": self.tabaquismo_var.get(),
                "alcohol": self.alcohol_var.get()
            }

            paciente = Paciente(id, edad, genero, sintomas, resultados_pruebas, antecedentes_familiares, habitos)
            paciente = self.sistema.procesar_paciente(paciente)

            resultado = f"Paciente ID: {paciente.id}\n"
            resultado += f"Diagnóstico: Cáncer de {paciente.diagnostico.tipo}, Estadio {paciente.diagnostico.estadio}\n"
            resultado += f"Tratamiento recomendado: {paciente.tratamiento.tipo} ({paciente.tratamiento.duracion})\n"
            resultado += f"Detalles del tratamiento: {paciente.tratamiento.detalles}\n"

            self.resultado_text.delete("1.0", tk.END)
            self.resultado_text.insert(tk.END, resultado)

        except ValueError as e:
            messagebox.showerror("Error", str(e))

if __name__ == "__main__":
    root = tk.Tk()
    app = InterfazGrafica(root)
    root.mainloop()

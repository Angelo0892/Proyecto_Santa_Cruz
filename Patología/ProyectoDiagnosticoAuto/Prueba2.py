import tkinter as tk
from tkinter import ttk, messagebox, scrolledtext
import numpy as np
import random  # Añadido para el diagnóstico aleatorio

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
            "pulmon": {
                1: Tratamiento("quimioterapia", "3 meses", "Cisplatino + Etopósido"),
                2: Tratamiento("quimioterapia + radioterapia", "6 meses", "Carboplatino + Paclitaxel + Radioterapia"),
                3: Tratamiento("quimioterapia + radioterapia + cirugia", "9 meses", "Neoadyuvancia + Lobectomía + Radioterapia adyuvante"),
                4: Tratamiento("inmunoterapia + cuidados paliativos", "indefinido", "Pembrolizumab + Manejo de síntomas")
            },
            "mama": {
                1: Tratamiento("cirugia + radioterapia", "4 meses", "Lumpectomía + Radioterapia"),
                2: Tratamiento("quimioterapia + cirugia + radioterapia", "8 meses", "AC-T + Mastectomía + Radioterapia"),
                3: Tratamiento("quimioterapia + cirugia + radioterapia + terapia hormonal", "12 meses", "AC-T + Mastectomía + Radioterapia + Tamoxifeno"),
                4: Tratamiento("quimioterapia + terapia hormonal + cuidados paliativos", "indefinido", "Capecitabina + Fulvestrant + Manejo de síntomas")
            },
            "colon": {
                1: Tratamiento("cirugia", "2 meses", "Colectomía parcial"),
                2: Tratamiento("cirugia + quimioterapia", "6 meses", "Colectomía + FOLFOX"),
                3: Tratamiento("quimioterapia + cirugia + quimioterapia", "9 meses", "FOLFOX neoadyuvante + Colectomía + FOLFOX adyuvante"),
                4: Tratamiento("quimioterapia + terapia dirigida + cuidados paliativos", "indefinido", "FOLFIRI + Bevacizumab + Manejo de síntomas")
            }
        }

    def diagnosticar(self, paciente):
        tipos_cancer = ["pulmon", "mama", "colon"]
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
        self.master.title("Sistema Experto Oncológico")
        self.master.geometry("600x800")
        self.sistema = SistemaExpertoOncologico()
        self.crear_widgets()

    def crear_widgets(self):
        notebook = ttk.Notebook(self.master)
        notebook.pack(fill=tk.BOTH, expand=True, padx=10, pady=10)

        # Pestaña de Datos del Paciente
        frame_paciente = ttk.Frame(notebook)
        notebook.add(frame_paciente, text="Datos del Paciente")

        ttk.Label(frame_paciente, text="ID del Paciente:").grid(row=0, column=0, sticky="w", padx=5, pady=5)
        self.id_entry = ttk.Entry(frame_paciente)
        self.id_entry.grid(row=0, column=1, padx=5, pady=5)

        ttk.Label(frame_paciente, text="Edad:").grid(row=1, column=0, sticky="w", padx=5, pady=5)
        self.edad_entry = ttk.Entry(frame_paciente)
        self.edad_entry.grid(row=1, column=1, padx=5, pady=5)

        ttk.Label(frame_paciente, text="Género:").grid(row=2, column=0, sticky="w", padx=5, pady=5)
        self.genero_var = tk.StringVar()
        ttk.Radiobutton(frame_paciente, text="Masculino", variable=self.genero_var, value="masculino").grid(row=2, column=1, sticky="w", padx=5, pady=2)
        ttk.Radiobutton(frame_paciente, text="Femenino", variable=self.genero_var, value="femenino").grid(row=3, column=1, sticky="w", padx=5, pady=2)

        # Pestaña de Síntomas
        frame_sintomas = ttk.Frame(notebook)
        notebook.add(frame_sintomas, text="Síntomas")

        self.tos_var = tk.BooleanVar()
        self.perdida_peso_var = tk.BooleanVar()
        self.dolor_abdominal_var = tk.BooleanVar()
        self.fatiga_var = tk.BooleanVar()

        ttk.Checkbutton(frame_sintomas, text="Tos crónica", variable=self.tos_var).grid(row=0, column=0, sticky="w", padx=5, pady=2)
        ttk.Checkbutton(frame_sintomas, text="Pérdida de peso", variable=self.perdida_peso_var).grid(row=1, column=0, sticky="w", padx=5, pady=2)
        ttk.Checkbutton(frame_sintomas, text="Dolor abdominal", variable=self.dolor_abdominal_var).grid(row=2, column=0, sticky="w", padx=5, pady=2)
        ttk.Checkbutton(frame_sintomas, text="Fatiga", variable=self.fatiga_var).grid(row=3, column=0, sticky="w", padx=5, pady=2)

        # Pestaña de Resultados de Pruebas
        frame_pruebas = ttk.Frame(notebook)
        notebook.add(frame_pruebas, text="Resultados de Pruebas")

        ttk.Label(frame_pruebas, text="Tamaño del tumor (cm):").grid(row=0, column=0, sticky="w", padx=5, pady=5)
        self.tumor_entry = ttk.Entry(frame_pruebas)
        self.tumor_entry.grid(row=0, column=1, padx=5, pady=5)

        ttk.Label(frame_pruebas, text="Nivel marcador tumoral:").grid(row=1, column=0, sticky="w", padx=5, pady=5)
        self.marcador_entry = ttk.Entry(frame_pruebas)
        self.marcador_entry.grid(row=1, column=1, padx=5, pady=5)

        ttk.Label(frame_pruebas, text="Nivel de hemoglobina:").grid(row=2, column=0, sticky="w", padx=5, pady=5)
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
            if self.tos_var.get():
                sintomas.append("tos cronica")
            if self.perdida_peso_var.get():
                sintomas.append("perdida de peso")
            if self.dolor_abdominal_var.get():
                sintomas.append("dolor abdominal")
            if self.fatiga_var.get():
                sintomas.append("fatiga")
            
            tamanio_tumor = float(self.tumor_entry.get())
            nivel_marcador = float(self.marcador_entry.get())
            nivel_hemoglobina = float(self.hemoglobina_entry.get())

            antecedentes_familiares = self.antecedentes_var.get()
            
            habitos = []
            if self.tabaquismo_var.get():
                habitos.append("tabaquismo")
            if self.alcohol_var.get():
                habitos.append("alcohol")

            paciente = Paciente(
                id=id,
                edad=edad,
                genero=genero,
                sintomas=sintomas,
                resultados_pruebas={
                    "tamaño_tumor": tamanio_tumor,
                    "nivel_marcador_tumoral": nivel_marcador,
                    "nivel_hemoglobina": nivel_hemoglobina
                },
                antecedentes_familiares=antecedentes_familiares,
                habitos=habitos
            )

            paciente_procesado = self.sistema.procesar_paciente(paciente)

            resultado = f"Diagnóstico: Cáncer de {paciente_procesado.diagnostico.tipo}, Estadio {paciente_procesado.diagnostico.estadio}\n\n"
            if paciente_procesado.tratamiento:
                resultado += f"Tratamiento recomendado:\n"
                resultado += f"Tipo: {paciente_procesado.tratamiento.tipo}\n"
                resultado += f"Duración: {paciente_procesado.tratamiento.duracion}\n"
                resultado += f"Detalles: {paciente_procesado.tratamiento.detalles}"
            else:
                resultado += "No se pudo determinar un tratamiento."

            self.resultado_text.delete(1.0, tk.END)
            self.resultado_text.insert(tk.END, resultado)
        except ValueError as e:
            messagebox.showerror("Error", str(e))

if __name__ == "__main__":
    root = tk.Tk()
    app = InterfazGrafica(root)
    root.mainloop()
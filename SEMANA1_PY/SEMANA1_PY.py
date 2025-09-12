# PROYECTO DE SEMANA 03 
from pprint import pprint


def ejer1():
    NOMBRE = input("INGRSE SU NOMBRE:")
    CARRERA = input("INGRESE SU CARRERA:")

    print(f"\n TU NOMBRE ES {NOMBRE} BIENVENIDO(A) A TU PRIMERA CLASE DE {CARRERA}")

def ejer2():
    print("\"Madeleine\"")

def ejer3():
    X= int(input("INGRESE X:"))
    Y= int(input("INGRESE Y:"))

    print("SUMA:",(X+Y))
    print("RESTA:",(X-Y))
    print("MULTIPLICACION:",(X*Y))
    print("DIVISION:",(X/Y))

import math

def ejer4():
  print("-------OPERACIONE--------: ")
num = float(input("INGRESE UN NUMKERO DECIMAL:"))

print("raiz cuadrada2: " ,math.sqrt(num))
print("redondeado: ", round(num ))
print("al cubo 3 :", math.pow(num, 3))
print("raiz cubica: ", math.pow(num, 1 / 3))


def ejer5():
    print("-------OPERACIONE--------: ")
num = float(input("INGRESE UN NUMERO: "))

deci= float(num)
entero= round (deci)
           

print(" resto: " + entero % 2)
print(" divi 3: " + deci / 3)

ejer5():
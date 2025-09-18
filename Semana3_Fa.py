def ejer1():
    nombre = input("Ingrese su nombre:")
    carrera = input("Ingrese su carrera:")

    print(f"\n{nombre}, bienvenido al curso FA de {carrera}")

def ejer2():
    print("\"tella\"")

def ejer3():
    x = int(input("Ingrese x:"));
    y= int(input("Ingrese y:"));

    print ("\nSuma: ",(x+y))
    print ("Resta: ",(x-y))
    print ("Multi: ",(x*y))
    print ("Divi: ",(x/y))

import decimal
import math 

def ejer4():
    num= float(input("Ingrese un numero decimal:"))
    print("raiz2:" ,math.sqrt(num))
    print("redondendo:" , round(num))
    print("al cubo :" , math.pow(num,3))
    print("raiz3:" , math.pow(num,1/3))

def ejer5():
    num= input("Ingrese un numero :")

    dec = float(num)
    entero =round(dec)

    print("resto : ",  entero%2)
    print("divi 3 :" , dec/3)


     







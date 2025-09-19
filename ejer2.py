lado1 = int(input("ingrese lado 1 "))
lado2 = int(input(" ingrerse  lado 2"))
lado3 = int(input("ingrese lado 3 "))


if lado1 == lado2 == lado3:
    print("equilatero")
elif lado1 == lado2 or lado1 == lado3 or lado2 == lado3:
    print("isosceles ")
else :
    print("esacaleno")

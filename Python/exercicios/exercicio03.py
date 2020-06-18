# -*- coding: utf-8 -*-

# 3- Escreva um programa que resolva uma equação de segundo grau.   

print("Equação de 2º grau\n")

from math import sqrt

notaA = int(input("Insira o valor de A : "))
notaB = int(input("Insira o valor de B : "))
notaB = int(input("Insira o valor de C : "))

delta = (b**2)- (4*a*c)
deltaraiz = sqrt(delta)

if delta < 0:
    print("Delta é negativo")
else:
    x1 = (-b + deltaraiz/2*a)
    print("X1 = "+ x1)
    x2 = (-b - deltaraiz/2*a)
    print("X2 = "+ x2)
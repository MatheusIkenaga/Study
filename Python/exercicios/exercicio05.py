# -*- coding: utf-8 -*-

# 5- Escreva um programa que receba dois números e um sinal, e faça a operação matemática definida pelo sinal.   

print("calculadora\n")

num1 = int(input("Digite o primeiro número: "))
sinal = input("Digite o sinal: ")
num2 = int(input("Digite o segundo número: "))

if sinal == "+":
    print(num1 + num2)
if sinal == "-":
    print(num1 - num2)
if sinal == "*":
    print(num1 * num2)
if sinal == "/":
    print(num1 / num2)
# -*- coding: utf-8 -*-
a = "Matheus Ikenaga"
tamanho = len(a)

print(tamanho) # tamanho da string

print(a[2]) # 2 é a posição do caractere

print(a[0:7])

print(a.lower())
print(a.upper())

b = "String com caractere especial \n"
print(b.strip())

minhaString = "As circunstancias a nossa volta nao determinam o nosso destino"
minhaLista = minhaString.split(" ")
print(minhaLista)

busca = minhaString.find("a ") #pega a posição da string "a "
print(busca) 
print(minhaString[busca:]) #usando o range a partir da posição da string busca até o final



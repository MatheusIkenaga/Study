# -*- coding: utf-8 -*-
x = [1,2,3,4,5]
y = []

#Sem List Comprehension
for i in x:
    y.append(i**2) #todos os números de x elevado ao quadrado

print(x)
print(y)

# ----------------  Com list comprehension   ------------------

#Formato -> [Vlr_a_adicionar  laço  condição]
z = [i**2 for i in x] #não tem condição
print("\nUsing list comprehension")
print(x)
print(z)

#usando a condição

impares = [i for i in x if i%2==1]
print("\nImpares")
print(impares)
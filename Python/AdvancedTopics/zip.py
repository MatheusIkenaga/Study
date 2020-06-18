# -*- coding: utf-8 -*-

#junta informações de diversas listas

lista1 = [1,2,3,4,5]
lista2 = ["Açai","Bala","Card","Dadinho","Empada"]
lista3 = ["R$ 8,00","R$ 2,00","R$ 1,00","R$ 0,20","R$ 3,00"]

for index, nome, valor in zip(lista1, lista2, lista3):
    print(index, nome, valor)
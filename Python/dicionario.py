mydictionary ={"A" : "Apple", "B":"Ball", "C": "Cat"}

#print(mydictionary["A"])

'''
for key in mydictionary:
    print(key)
    print(mydictionary[key])

'''

for i in mydictionary.items():  #retorna duplas
    print(i)

for i in mydictionary.values(): #return values
    print(i)

for i in mydictionary.keys(): #return keys
    print(i)
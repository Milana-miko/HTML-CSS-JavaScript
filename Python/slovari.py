d = {'test':1, 'test_2':"TEST"}
print (d['test_2'])



a = dict (short='dict', longer='dictionary')
a['short'] = 234
print (a)




z = dict ([(23,34), (56,87)])
print (z)


f = dict.fromkeys (['a','b'], 1)
print (f)


b = {a: a**2 for a in range (7)}
print (b)



person = {'name': {'last_name': 'Иванов', 'first_name': 'Иван', 'middle_name': 'Иванович'}, 'address': ['г. Андрюшки', 'ул. Васильковская д. 236', 'кв. 12'], 'phone': {'home_phone': '36-35-42', 'mobile_phone': '8-364-654-125', 'mobile_phone_2': 'Нет'}}
print (person['name'] ['first_name'])
print (person['address'] [2])
print (person['phone'])


#person.clear () # ochishaet slovar
#print (person)


print(person.values ()) # vozvrashaet znacheniya v slovare


print (person.keys ())

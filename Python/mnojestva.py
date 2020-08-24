a= set ('hello')
print (type (a))
print (a)


b = {'23',32}
print (type (b))
print (b)



c = {i**2 for i in range (10)}
print (type (c))
print (c)


e = set('hello')
f = frozenset ('qwerty')
e.add (1)
print (e)



g =['r', 's', 'w', 'a','s', 'w']
print (g)
print (set(g))



h ={32,45, 43.23, 76}
x=45
print (x in h)




k = {32,45, 43.23, 76}
z={67,76,90}
print (k.isdisjoint (z))




k = {32,45, 43.23, 76}
z={67,76,90}
print (k==z)


m = {32,45, 43.23, 76}
n={23,45,12,43.23}
m.update (n)
print (m)



m = {32,45, 43.23, 76}
n={23,45,12,43.23}
m.intersection_update (n)
print (m)



m = {32,45, 43.23, 76}
n={23,45,12,43.23}
m.difference_update (n)
print (m)



m = {32,45, 43.23, 76}
n={23,45,12,43.23}
m.symmetric_difference_update (n)
print (m)


m = {32,45, 43.23, 76}
n={23,45,12,43.23}
m.add(63)
print (m)



m = {32,45, 43.23, 76}
n={23,45,12,43.23}
m.remove(32)
print (m)


m = {32,45, 43.23, 76}
n={23,45,12,43.23}
m.discard(32)
print (m)



m = {32,45, 43.23, 76}
n={23,45,12,43.23}
m.pop()
print (m)



m = {32,45, 43.23, 76}
n={23,45,12,43.23}
m.clear()
print (m)

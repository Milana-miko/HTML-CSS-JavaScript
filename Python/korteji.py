a = (43,56,45.23,'d')
b = [43,56,45.23,'d']

b[0] = 34

print (a.__sizeof__())
print (b.__sizeof__())


g = tuple ('hello world')
print (g)


h = "hi everyone"
print (h)


z= "good morning", "hi", 345
print (z)

print (z.count (345))

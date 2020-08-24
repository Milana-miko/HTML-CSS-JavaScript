#def multiply(a, b):
    #res = a * b
    #return res
#print (multiply (2, 5))


#unique_in_order('AAAABBBCCDAABBB') == ['A', 'B', 'C', 'D', 'A', 'B']
#unique_in_order('ABBCcAD')         == ['A', 'B', 'C', 'c', 'A', 'D']
#unique_in_order([1,2,2,3,3])       == [1,2,3]




##def bool_to_word(boolean):
##    a = int (input ("Insert the number: "))
##    b = int (input ("Insert the number: "))
##    return a
##    return b
##
##    if a>= b:
##        print ("True")
##    else:
##        print ("False")
        
  
##name= input ("vvedite imya: ")
##print ("Hello", name)
##
##
##a = int (input())
##print (a*2)
##
##
##a = int(input())
##b = int(input())
##print (a*b)
##
##X = int(input())
##Y = int(input())
##print(X*60 + Y)



##x = int(input())
##y = (x // 60)
##z = (x % 60)
##print(y)
##print(z)




##X = int(input())   
##H = int(input())   
##M = int(input())   
##Hour = (H + (X+M)//60)
##Min = ((M + X)% 60)
##print(Hour)
##print(Min)



##x = 5
##y = 10
##print (y > x * x or y >= 2 * x and x < y)



##A = int(input())
##B = int(input())
##H = int(input())
##if A<=H<=B:
##    print ("Это нормально")
##elif A>H<B:
##    print ("Недосып")
##elif A<H>B:
##    print ("Пересып")



##x = int(input())
##if (-15<x<=12) or (14<x<17) or (19<=x):
##    print (True)
##else:
##    print (False)






##a = float(input())
##b = float(input())
##c = input()
##if b == 0 and (c == "div" or c == "mod" or c == "/"):
##    print("Деление на 0!")
##elif c == "+":
##    print(a + b)
##elif c == "-":
##    print(a - b)
##elif c == "/":
##    print(a / b)    
##elif c ==  "*":
##    print(a * b)
##elif c == "pow":
##    print (a ** b )
##elif c == "mod":
##    print (a % b)
##elif c == "div":
##    print(a // b)




##x = input()
##if x == "треугольник":
##    a = float (input ())
##    b = float (input ())
##    c = float (input ())
##    p = (( a + b + c)/2)
##    S = (p * (p - a) * (p - b) * (p - c)) ** 0.5
##    print (S)
##if x == "прямоугольник":
##    a = float (input ())
##    b = float (input ())
##    S = a * b
##    print (S)     
##if x == "круг":
##    r = float (input ())
##    P = 3.14
##    S = P * (r * r)
##    print (S) 


##a, b, c, d, e, f = map (int, input ().split())  
##if (a + b + c) == (d + e + f):
##    print ("Счастливый")
##else:
##    print ("Обычный")



##a = int(input())
##b = int(input())
##c = int(input())
##if a >= b >= c: 
##    print(a)
##    print(c)
##    print(b)
##elif a >= c >= b:
##    print(a)
##    print(b)
##    print(c)
##elif b >= a >= c: 
##    print(b)
##    print(c)
##    print(a)
##elif b >= c >= a: 
##    print(b)
##    print(a)
##    print(c)
##elif c >= a >= b: 
##    print(c)
##    print(b)
##    print(a)
##else: 
##    print(c)
##    print(a)
##    print(b)



##a = int (input ())
##if a % 10 == 1 and a % 100 != 11:
##    print (str(a) + " программист")
##elif a % 10 == 2 and a % 100 != 12 or a % 10 == 3 and a % 100 != 13 or a % 10 == 4 and a % 100 != 14:
##    print (str(a) + " программиста")
##else:
##    print (str(a) + " программистов")


##a,b,c,d,e,f=str(input())
##if int(a)+int(b)+int(c)==int(d)+int(e)+int(f):
##    print("Счастливый")
##else:
##    print("Обычный")



##a = 1
##s = 0
##while a != 0:
##    a = int (input ())
##    s += a
##print (s)


##a = int(input())
##b = int(input())
##d = 1
##while d % a != 0 or  d % b != 0:
##    d += 1
##else:
##    print(d)




##i = 0
##s = 0
##while i < 10:
##    i = i + 1
##    s = s + i
##    if s > 15:
##        break
##    i = i + 1
##    print (i)


##while True:
##    a = int(input())
##    if a < 10:
##        continue
##    elif a > 100:
##        break
##    else:
##        print(a)

    
##a, b, c, d = int(input()), int(input()),int(input()),int(input())
##for i in range(c, d+1):
##    print('\t', i, end='')
##print()
##for j in range(a, b+1):
##    print( j, end='')
##    for g in range(c, d+1):
##        print('\t', g*j, end='')
##    print()




##a, b = int (input()), int (input())
##summa = 0
##kol = 0
##for i in range (a, b+1):
##    if i % 3 == 0:
##        summa +=i
##        kol +=1
##print (summa/kol)








##a = input().lower()
##b = 0
##c = len(a)
##if "g" or "G" or "c" or "C" in a:
##    b = a.count("g") + a.count ("c") 
##    res = (b / c)*100
##    print (res)
    



##s = 'abcdefghijk'
##print (s[3:6])
##print (s[:6])
##print (s[3:])
##print (s[::-1])
##print (s[-3:])
##print (s[:-6])
##print (s[-1:-10:-2])



    
        

##s = input()
##count = 1
##x = 1
##j = s[x:x+1]
##for i in s:
##    if i in j:
##        count += 1
##    else:
##        print(i, end='')
##        print(count, end='')
##        count = 1
##    x += 1
##    j = s[x:x+1]


##print(sum([int(i) for i in input().split()]))




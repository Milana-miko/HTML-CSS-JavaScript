l = [] # пустой список
lis = [1,56,'x', 34, 2.34,['s','t','r','o','k','a']]
print (lis)

a = [a+b for a in 'list' if a !='s' for b in 'soup' if b!= 'u']
print (a)

l.append (23) # dobavlyaet elemnt v konec etogo spiska
l.append (34)
l.append (34)
b = [24,67,34]
l.extend (b) # rasshiryaet spisok novym spiskom , dobavlyaet v konec
l.insert (1,56) # vstavlyaet element po indexu
l.remove (34) # udalyaet pervyy element v spiske imeyushiy zadannoe znachenie 
l.pop () #esli index ne ukazen udalyaet posledniy element
l.pop (0) # udaalyaet ityy element i vozvrashaet ego, esli nichego ne ukazat udalyaet posledniy element 
print (l.index (56)) # vozvrashaet index elementa v spiske
print (l.count (34)) # vozvrashaet kolichestvo ukaannyx elementov v spiske
l.sort () # sortiruet spisok v poryadke vozrastaniya
l.reverse () # perevorachivaet ves spisok
l.clear () # ochishaet vesx spisok

print (l)

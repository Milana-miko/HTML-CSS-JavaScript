from colorama import init
from colorama import Fore, Back, Style
# use Colorama to make Termcolor work on Windows too
init()
print (Back.GREEN)
what = input ('chto delaem? (+,-):')
print (Back.MAGENTA)
a = float (input ('vvedite pervoe chislo:'))
b = float (input ('vvedite vtoroe chislo:'))
if what == '+':
    c = a+b
    print ("rezultat:" + str (c))

elif what == "-":
    c = a-b
    print ("rezultat:" + str (c))
else:
    print ('vybor ne vern!!!')



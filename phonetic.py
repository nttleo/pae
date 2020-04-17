# phonetic alphabet encoder (py)
import os
from time import sleep
os.system("color 5")
print('PHONETIC ALPHABET ENCODER!')
sleep(2)
system('cls')
os.system("color f")
while True:
    print('insert a text right bellow: ')
    txt = input('').lower().strip()
    code = {
    'a': 'alpha', 
    'b': 'bravo', 
    'c': 'charlie', 
    'd': 'delta', 
    'e': 'echo', 
    'f': 'foxtrot', 
    'g': 'golf', 
    'h': 'hotel', 
    'i': 'india', 
    'j': 'juliet', 
    'k': 'kilo', 
    'l': 'lima', 
    'n': 'november', 
    'm': 'mike', 
    'o': 'oscar', 
    'p': 'papa', 
    'q': 'quebec', 
    'r': 'romeo', 
    's': 'sierra', 
    't': 'tango', 
    'u': 'uniform', 
    'v': 'victor', 
    'w': 'whiskey', 
    'x': 'xray', 
    'y': 'yankee',
    'z': 'zulu'
    }
    print("\n")
    for x in txt:
        if x in code:
            print(code[x])
        else:
            print(x)
    print("\n\n")
    continue

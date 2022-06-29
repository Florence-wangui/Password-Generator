import random as rand
chars = "abcdefghijklmnopqrstuvwxyz"
CHARS = chars.upper()
symbols = "[]{}()*;/,._-"
numbers = "0123456789"

allVariables = chars + CHARS + symbols + numbers
len = 16

password = "".join(rand.sample(allVariables, len))

print(password)

# Output:
#  jiTkmqeJw1/s2dzB
#  5E{6eoGTJ*yru;vN
#  ,Rrkwdj]z*b2/q)S
#  _shXE(0;pu8LJd{z
#  v;3(0_iUFoG5uDV1

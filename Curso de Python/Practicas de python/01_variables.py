# Variables 

my_string_variable = "My String variable"
print(my_string_variable)

my_int_variable = 5
print(my_int_variable)

my_int_to_str_variable = str(my_int_variable)
print(my_int_to_str_variable)
print(type(my_int_to_str_variable))

my_bool_variable = False
print(my_bool_variable)

# Concatenacion de variables en un print
print(my_string_variable , my_int_variable , my_bool_variable) 
print("Este es el valor de:", my_bool_variable)

#Funciones del sistema

print(len(my_string_variable))          

# Variables en una sola linea ¡Cuidado con abusar de esta sintaxix!

name, surname , alias , age = "Manuel Starling" , "de los Santos Castro" , "Manolito" , 19

print("Tu nombre completo es:", name + surname , "\nTu alias es:" ,  alias , "\n Tu edad es:" ,  age)

#Inputs
""""
name = input("¿Cuál es tu nombre? ")
age = input("¿Cual es tu edad? ")

print("Hola ", name)
print("Tu edad es", age)
"""

# Cambiamos su tipo

name = 19
age = "Manuel" 

print (name)
print(age)

# ¿Forzamos el tipo?
address: str =  "Mi dirección: "
address = 32
print(address)
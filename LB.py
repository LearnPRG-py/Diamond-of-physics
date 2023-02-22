import base64

lb = {}
lbn = []
# Function calling
def dictionairy():
 
    # Declaring hash function
    
 
    # Note that it will sort in lexicographical order
    # For mathematical way, change it to float
    print(sorted(lb.items(), key=lambda kv:
                 (kv[1], kv[0])))
 
 

def add_ent():
    scr = int(input('enter your score: '))
    tri = int(input('enter your tries: '))
    accu = scr/tri
    name = input('enter your 3 letter game username: ')
    lb[name]=accu

for i in range(100000000000):
    cmd = input("enter command: ")
    if cmd == "add":
        add_ent()
    if cmd == "view":
        dictionairy()

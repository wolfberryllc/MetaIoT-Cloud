def average(array):
    array = set(array)
    return sum(array)/len(array)



from firebase import firebase
import pyfirmata
import serial
from datetime import datetime




firebase = firebase.FirebaseApplication('https://planter-ai-default-rtdb.firebaseio.com', None)

import time
ser = serial.Serial('/dev/ttyACM0',9600)
A0 = []
A1 = []
A2 = []
A3 = []
resultcontr = 0
tenMiutes = 0
while True: 

    try:
        b = ser.readline()
        print(b)
        b = b.rstrip()
        b=b.decode("utf-8")
    except:
        b = 0


    if resultcontr == 0:
        try:
            A0.append(int(b))
            
        except:
            A0.append(0)
        
        resultcontr = 1
    elif resultcontr == 1:
        try:
            A1.append(int(b))
        except:
            A1.append(0)
            
        resultcontr = 2
    elif resultcontr == 2:
        try:
            A2.append(int(b))
        except:
            A2.append(0)
            
        resultcontr = 3
    elif resultcontr == 3:
        try:
            A3.append(int(b))
        except:
            A3.append(0)
            
        resultcontr = 0
    
    tenMiutes = tenMiutes + 1
    
    if tenMiutes == 600:
        print("10 minutes passes")
        tenMiutes = 0

        ao = average(A0)
        a1 = average(A1)
        a2 = average(A2)
        a3 = average(A3)



        current_utc = datetime.utcnow()

      
        data = [{"A0":ao},{"A1":a1},{"A2":a2},{"A3":a3},{"Time":current_utc }]


        result = firebase.post('/Scorelist/',data)



        print(data)



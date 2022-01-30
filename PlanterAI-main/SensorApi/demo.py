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
    b = ser.readline()
    b = b.rstrip()
    b=b.decode("utf-8")

    b = int(b)
    b = ( 100 - ( (b/1023.00) * 100 ) )


    if resultcontr == 0:
        A0.append(int(b))
        resultcontr = 1
    elif resultcontr == 1:
        A1.append(int(b))
        resultcontr = 2
    elif resultcontr == 2:
        A2.append(int(b))
        resultcontr = 3
    elif resultcontr == 3:
        A3.append(int(b))
        resultcontr = 0
    
    tenMiutes = tenMiutes + 1
    
    if tenMiutes == 600:
        print("10 minutes passes")
        tenMiutes = 0

        ao = average(A0)
        a1 = average(A1)
        a2 = average(A2)
        a3 = average(A3)

        ao = ( 100 - ( (ao/1023.00) * 100 ) )
        a1 = ( 100 - ( (a1/1023.00) * 100 ) )
        a2 = ( 100 - ( (a2/1023.00) * 100 ) )
        a3 = ( 100 - ( (a3/1023.00) * 100 ) )

        current_utc = datetime.utcnow()

      
        data = [{"A0":ao},{"A1":a1},{"A2":a2},{"A3":a3},{"Time":current_utc }]


        result = firebase.post('/Scorelist/',data)



        print(data)

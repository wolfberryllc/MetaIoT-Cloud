int sensorPin0 = A0;


int sensorPin1 = A1;


int sensorPin2 = A2;


int sensorPin3 = A3;


int sensorPin4 = A4;


int sensorPin5 = A5;


int sensorPin6 = A6;



int sensorPin7 = A7; 



int sensorValue0 = 0;  


int sensorValue1 = 0;  


int sensorValue2 = 0;  


int sensorValue3 = 0;


int sensorValue4 = 0;


int sensorValue5 = 0;


int sensorValue6 = 0;


int sensorValue7 = 0;  


int moisture1_value_0 = 0 ;


int moisture1_value_1 = 0 ;


int moisture1_value_2 = 0 ;


int moisture1_value_3 = 0 ;







int moisture1_value_4 = 0 ;


int moisture1_value_5 = 0 ;


int moisture1_value_6 = 0 ;


int moisture1_value_7 = 0 ;















void setup() {







 pinMode(sensorPin0,INPUT);







 pinMode(sensorPin1,INPUT);







 pinMode(sensorPin2,INPUT);







 pinMode(sensorPin3,INPUT);







 pinMode(8,OUTPUT);







 Serial.begin(9600);


 Serial.print("Fab"); 




}







void loop() {







 sensorValue0 = analogRead(sensorPin0);







 sensorValue1 = analogRead(sensorPin1);







 sensorValue2 = analogRead(sensorPin2);







 sensorValue3 = analogRead(sensorPin3); 











 moisture1_value_0 =map(sensorValue0,590,360,0,100);







 moisture1_value_1 =map(sensorValue1,590,360,0,100);







 moisture1_value_2 =map(sensorValue2,590,360,0,100);







 moisture1_value_3 =map(sensorValue3,590,360,0,100);



 



 moisture1_value_4 =map(sensorValue4,590,360,0,100);



  



 moisture1_value_5 =map(sensorValue5,590,360,0,100);



 



 moisture1_value_6 =map(sensorValue6,590,360,0,100);



 moisture1_value_7 =map(sensorValue7,590,360,0,100);



 Serial.println("Hello World");

 Serial.println(moisture1_value_0);



 Serial.println(moisture1_value_1);



 Serial.println(moisture1_value_2);

 

 Serial.println(moisture1_value_3);



 delay(12000); 





}

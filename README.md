# MetaIoT-Cloud: A system for monitoring, visualizing, and storing sensor data in the cloud.

MetaIoT-Cloud is a comprehensive system for monitoring, visualizing, and storing sensor data in the cloud. It offers an end-to-end solution for collecting, managing, analyzing, and visualizing real-time data, providing valuable insights and enabling informed decisions. It utilizes powerful tools to monitor and manage large-scale sensor networks, allowing users to visualize and manage data in a simple and efficient manner. It also offers an intuitive user interface for easily configuring and managing devices, as well as powerful analytics and visualization tools for extracting meaningful insights and taking action. Furthermore, MetaIoT-Cloud allows users to securely store data in the cloud and access it from anywhere, anytime. It also provides automated alerts and notifications for quickly responding to changes in the data. With MetaIoT-Cloud, users can easily and quickly gain insights from their sensor data and make more informed decisions.

## *Available now - Sensor to Data Visualization and Cloud Storage ✅

![1667482098370](https://user-images.githubusercontent.com/53659320/199795349-5d41cfd8-5322-4a0f-b42f-3ef006289b0c.jpg)

### This project helps developers prototype and publish sensor-driven (Apps) using Unity3d, Firebase, and Google Cloud. 


Starter Project (Planter AI Web App) + Raspberry Pi + Arduino + Unity + Firebase + Google Cloud.


We've developed an innovative sensor-driven application called Planter AI, which combines Raspberry Pi, Arduino, Unity, Firebase, and Google Cloud to help developers prototype and publish their apps quickly and easily. 

Using Python APIs, you are able to store data collected from the Raspberry Pi into Google Firebase. This data is then collected from Firebase and displayed in Unity for a mobile application, and can be accessed through a static IP address. 


### Accounts Needed 

![Asset 2](https://user-images.githubusercontent.com/21232416/196292350-6d3745db-c8a0-42b1-b3bd-c1f502291eb6.png)

- Google Firebase [Google Firebase Website](https://firebase.google.com/)

- Unity3d [Unity3d](https://id.unity.com/en/conversations/1f2147f1-98fe-445d-a797-7bf5357d6c5c001f)

### Software Requirements 
Before you begin on your Raspberry pi make sure that you have all the installed software and you have ran the most recent updates.

```
sudo apt update
```

1. Arduino IDE [Download](https://www.arduino.cc/en/software)

```
sudo apt install arduino
```

2. Visual Studio Code [Download](https://code.visualstudio.com/docs/setup/raspberry-pi)

```
sudo apt install code
```

### Hardware Requirements

![Asset 3](https://user-images.githubusercontent.com/21232416/196295183-b9934274-4904-4486-aef0-df41b0a34e33.png)


- Raspberry Pi available at [Seeed Studio](https://www.seeedstudio.com/Raspberry-Pi-4-Computer-Model-B-4GB-p-4077.html)

- Arduino Uno R3 available at [Seeed Studio](https://www.seeedstudio.com/Arduino-Uno-Rev3-p-2995.html)

- Arduino Sensor Kit Base available at [Seeed Studio](https://www.seeedstudio.com/Arduino-Sensor-Kit-Base-p-4743.html)

- Capacative Soil Moisture Sensor available at [Seeed Studio](https://www.seeedstudio.com/Grove-Capacitive-Moisture-Sensor-Corrosion-Resistant.html)

- [Planter AI.pdf](https://github.com/wolfberryllc/MetaIoT-Cloud/files/10550835/MetaIoT-Cloud.pdf)

- [Planter AI Flowchart.pdf](https://github.com/wolfberryllc/MetaIoT-Cloud/files/10550841/Planter.AI.Flowchart.2022.pdf)


### Additional Hardware

- Mobile Phone iOS & Android

- Micro SD Card 64GB

# Steps

## Repository

1. Fork repository 

2. Create a folder on your Raspberry Pi desktop and name your project

3.  Open Terminal 

4.  Change Directory to the new folder you just created 

``` 
cd /foldername 
```

 - get clone

```
git clone https://(urlofrepository) 
```

- browse to the folder with another change directory

```
cd /MetaIoT/PlanterAI-main/SensorApi
```

## Verify Sensor Kit Base

Browse to [Arduino Sensor Kit Lessons](https://sensorkit.arduino.cc/?_gl=1*55nx9n*_ga*NzkyOTM2NDE1LjE2NjQ3MjUzMjk.*_ga_NEXN8H46L5*MTY2ODg2MzgyOS4xMy4xLjE2Njg4NjQwNDEuMC4wLjA.)
and run through the lessons to verify that your sensor kit base sensors are working properly. The values should display in through the serial monitor found in the tools section of the Arduino IDE. 




## Install Dependencies
These will be run in the home folder of the repository you just created and cloned to your desktop. Please note that you will also need Python installed with pip on the machine you are using to build your application. Only use this if any of the dependencies are not working within your app. 

1. Install Firebase [Firebase Website](https://firebase.google.com/docs/web/setup)

```
pip install python-firebase
```
or

```
 npm install firebase
 ```
 additionally you can run the command below if pip and npm do not work for you.
 
 ```
 pip install git+https://github.com/ozgur/python-firebase
 
```


2. Install pylance [pylance Webpage](https://pypi.org/project/pylance/)

```
pip install pylance
```

3. Install pyFirmata [pyFirmata Website ](https://pypi.org/project/pyFirmata/)

```
pip install pyFirmata
```
4. Install Flask [Flask Website](https://pypi.org/project/Flask/)

``` 
pip install Flask
```

5. Install Flask SocketIO [Flask SocketIO website](https://pypi.org/project/Flask-SocketIO/)

``` 
pip install Flask-SocketIO 
```

6. Install Pyrebase [Pyrebase Website](https://pypi.org/project/Pyrebase/)

```
pip install Pyrebase
```

7. Install Eventlet [Eventlet Website ](https://pypi.org/project/eventlet/)

``` 
pip install eventlet
```

 ## Firebase
 
 ### Create Firebase Project
 
Once you have created your Firebase account browse to your console 
https://console.firebase.google.com/ and click add project


<img src="https://user-images.githubusercontent.com/21232416/197349244-c554be1f-1ff1-4ae2-b806-1dc000a70463.png" width="400" height="280">
Then you will be prompted to create a project name. Please feel free to use whatever name you would like.

<img src="https://user-images.githubusercontent.com/21232416/197349259-5268ce8c-b3a1-46d5-939c-5cce3a32d164.png" width="400" height="280">

<img src="https://user-images.githubusercontent.com/21232416/197349265-645de8b1-b485-45a2-994f-07d7a5926728.png" width="400" height="280">

Next you will add Google Analytics 

<img src="https://user-images.githubusercontent.com/21232416/197349302-906c13d8-cf64-4041-adcc-8a99846afd49.png" width="400" height="280">

Select the Default Account for Firebase 

<img src="https://user-images.githubusercontent.com/21232416/197349320-f0983252-d54f-4a55-aa79-4b9f8ced6dca.png" width="400" height="280">


### Add Database 

Browse to build and Realtime Database on the left hand side of the console 

<img src="https://user-images.githubusercontent.com/21232416/197349353-2013b1cc-010e-4dfd-9306-d6063fd485fc.png" width="400" height="280">


at the top you will be given an option to Create Database

<img src="https://user-images.githubusercontent.com/21232416/197349371-d59f407b-9b4a-49ca-a23c-f23ba6e0ed98.png" width="400" height="280">

Select your Database location and hit next 

<img src="https://user-images.githubusercontent.com/21232416/197349374-a44a1508-76f0-4f07-bc9f-438230fdadc0.png" width="400" height="280">


For this project you will start in Test Mode. Once you have selected test mode select Enable

<img src="https://user-images.githubusercontent.com/21232416/197349392-8c235f05-7712-480f-98ea-45e600c5a61f.png" width="400" height="280">

You will now be taken back to the console and you are ready to add your app. 

<img src="https://user-images.githubusercontent.com/21232416/197349440-40fccc9a-b931-4b85-b882-342f6fca0f09.png" width="400" height="280">

Register your app and set up firebase hosting 

<img src="https://user-images.githubusercontent.com/21232416/197349452-30dbebae-6ef4-407a-876a-4b5121df9bbf.png" width="400" height="280">


After you register your app you will run NPM install from the terminal inside your Sensor
API folder. In the event NPM does not install in your folders create a package.json file and place the following code in it.

```
{
  "dependencies": {
 
  }
}

```

## Modifications

- The template design is located in SensorAPI /templates/index.html

- Modify lines 62 ---> 71 with your firebase database and application information from what you see on your screen. Take whats under

```
// Your web app's Firebase configuration
// For Firebase JS SDK v7.20.0 and later, measurementId is optional
```

Then save it

You will now go back to your terminal inside of the root folder of your project (SensorAPI folder)

Run npm install -g firebase-tools

You will now login to firebase using 

```
firebase login

```

Once you have logged in you will run 

```
firebase init
```

You will then see something similar to this in your terminal 

<img src="https://user-images.githubusercontent.com/21232416/197349614-c6f6dedc-51a7-4fe0-ad86-ce2b089ae22b.png" width="400" height="280">


Use the down arrow and space bar to select Hosting configure files for Firebase Hosting and (optionally) set up github action deploys 

Then hit enter

<img src="https://user-images.githubusercontent.com/21232416/197349642-8d1cf838-8370-44d8-aa40-88d35dd5a8d4.png" width="400" height="280">


In the next screen type y and hit enter and do the same for Configure as single page app and set up automatic builds 

<img src="https://user-images.githubusercontent.com/21232416/197349662-69625f66-0cda-49b9-8cb4-034a3f79bd70.png" width="800" height="250">

You will then see this screen 

<img src="https://user-images.githubusercontent.com/21232416/197349679-acd3c6fb-3c83-4829-95eb-c491e59690de.png" width="400" height="280">

type in your username and repo for the project username/MetaIoT

You should then see a screen similar to the one below. Run through the questions and use this screen
as a reference to the answers 

<img src="https://user-images.githubusercontent.com/21232416/197349694-9ecc64c4-b828-4b21-9331-389253b32f97.png" width="400" height="280">


 You will now see a public HTML file inside of your code files 
 
 <img src="https://user-images.githubusercontent.com/21232416/197349748-a31cdc53-099a-4793-a8ff-05dcb22f3abb.png" width="400" height="800">
 
 
 You will now copy your templates index.html and replace the index.html file in public

Now you can run 

```
firebase deploy

```

Browse to the url and you should now see the project template!





## Arduino Board

1. Connect the Arduino Base Sensor kit to Arduino Uno 

2. Plug the device into your Raspberry Pi or another computer using an installer

3. Download Arduino IDE available at [Arduino ](https://www.arduino.cc/en/software)

4. Upload Sketches located in
PlanterAI-main/SensorApi/AnalogInputArdinu/AnalogInputArdinu.ino
  
5. Upload Sketches located in 
PlanterAI-main/SensorApi/sketch_may21a/sketch_may21a.ino


## Run your project

from your SensorAPI folder run 

```
python3 demo.py
```

and then 

```
python3 main.py
```

## Database Security

***Coming Soon ***



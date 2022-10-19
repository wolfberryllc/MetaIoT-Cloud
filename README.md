# This IoT system is an end-to-end data route with visualization from sensors to storage.

## Phase 1 *Available now - Sensor to Data Visualization and Storage ✅



### This project (P1) helps developers prototype and publish sensor-driven (Apps) in augmented reality using Unity, Firebase and Google Cloud. 


P1.0 - Starter Project (Planter AI) + Unity 3D + Firebase + Google Cloud.

We've developed a sensor application (Python + Raspberry Pi + Arduino)

Stored the Python + Raspberry Pi data into Google Firebase through Python API's

Collected data from Firebase and displayed it in a Unity mobile application.

Displayed data on a static IP address from Firebase.

### Accounts Needed 

![Asset 2](https://user-images.githubusercontent.com/21232416/196292350-6d3745db-c8a0-42b1-b3bd-c1f502291eb6.png)

- Google Firebase [Google Firebase Website](https://firebase.google.com/)

- Unity3d [Unity3d](https://id.unity.com/en/conversations/1f2147f1-98fe-445d-a797-7bf5357d6c5c001f)

### Hardware Requirements

![Asset 3](https://user-images.githubusercontent.com/21232416/196295183-b9934274-4904-4486-aef0-df41b0a34e33.png)


- Raspberry Pi available at [Seeed Studio](https://www.seeedstudio.com/Raspberry-Pi-4-Computer-Model-B-4GB-p-4077.html)

- Arduino Uno R3 available at [Seeed Studio](https://www.seeedstudio.com/Arduino-Uno-Rev3-p-2995.html)

- Arduino Sensor Base Kit available at [Seeed Studio](https://www.seeedstudio.com/Arduino-Sensor-Kit-Base-p-4743.html)

- Capacative Soil Moisture Sensor available at [Seeed Studio](https://www.seeedstudio.com/Grove-Capacitive-Moisture-Sensor-Corrosion-Resistant.html)

### Additional Hardware

- Mobile Phone iOS & Android

# Steps

## Repository

1. Fork repository and Clone Repository

2. Create a folder on your desktop and name your project

3.  Open Terminal 

4.  cd to the new folder you just created 

``` 
cd /foldername 
```

 - get clone

```
git clone https://(urlofrepository) 
```

- browse to the folder with another change directory

```
cd /MetaIoT/PlanterAI-main
```

## Install Dependencies
These will be run in the home folder of the repository you just created and cloned to your desktop. Please note that you will also need Python installed with pip on the machine you are using to build your application

1. Install Firebase [Firebase Website](https://firebase.google.com/docs/web/setup)

```
python3 -m pip install python-firebase
```
or

```
 npm install firebase
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

## Modifications

- The template design is located in  SensorAPI /templates/index.html

- Modify lines 63 ---> 71 with your firebase database and application information

## Arduino Board

1. Connect the Arduino Base Sensor kit to Arduino Uno 

2. Plug the device into your Raspberry Pi or another computer using an installer

3. Download Arduino IDE available at [Arduino ](https://www.arduino.cc/en/software)

4. Upload Sketches located in
 PlanterAI-main/SensorApi/AnalogInputArdinu/AnalogInputArdinu.ino
  
5. Upload Sketches located in 
PlanterAI-main/SensorApi/sketch_may21a/sketch_may21a.ino
    
## Phase 2 Sensor to Hyperledger and Blockchain Storage with Visualization *Pending release :cyclone:
### This project (P2) helps developers prototype and publish sensor-driven (dApps) in augmented reality using Mobile Native, AWS, Hyperledger, and Cardano. 

P2.0 - Starter Project (Planter AI) + CrossPlatform Apps + AWS & Hyperledger + Blockchain Storage.

Phase 2.0  - In Development.

{Mobile dApp Development & Uploading to snapcraft.io, The App Store and Google Play using Augmented Reality (AR), AWS (Amazon Web Server & Services) + Hyperledger & Cardano} *Contact us for specifics using support@wolfberryllc.com - otherwise we will release all phase 2 assets, source code + notes around December 01 2022



## Phase 3 Management and Response System *Pending release 🌀
### This phase updates the backend to use Azure to Hyperledger to blockchain storage. 
A wallet management and response system using phase 2 will be completed in this new environment. 

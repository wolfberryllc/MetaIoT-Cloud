#!/usr/bin/env python3
from flask import Flask,render_template
import pyfirmata
from flask_socketio import SocketIO,emit,disconnect
#from flask_login import current_user
import eventlet
import time
import functools
import serial
import pyrebase
from datetime import datetime



async_mode = 'eventlet'
eventlet.monkey_patch()
app = Flask(__name__)

socketio = SocketIO(app, async_mode=async_mode)


@app.route('/')
def index():
    return render_template("index.html")
  
    
if __name__ == '__main__':
    #login_manager.init_app(app)
    socketio.run(app,debug=True)
#player ship class (could be extended to cover enemy movement

import pygame, sys

class Ship:
    def __init__(self, windowX, windowY):
        self.posX = 100 # X position of sprite
        self.posY = 100 # Y position of sprite
        self.sizeX = 32 # size of sprite X
        self.sizeY = 32 # size of sprite Y
        self.window_X = windowX # window size X
        self.window_Y = windowY # window size Y
        self.playerRect = pygame.Rect(100,100, 32,32) # creates a rectangle object 
        
    def moveDown (self, dist, time):
        self.posY += (dist * time)
        self.playerRect = self.playerRect.move(0, (dist * time))
        
        if self.posY > self.window_Y - self.sizeY:
            self.playerRect = self.playerRect.move(0,(self.window_Y - self.sizeY) - self.posY)
            self.posY = self.window_Y - self.sizeY
        
        
    def moveUp (self, dist, time):
        self.posY -= (dist * time)
        self.playerRect = self.playerRect.move(0, -(dist * time))
        
        if self.posY < 0:
            
            self.playerRect = self.playerRect.move(0 , -(self.posY))
            self.posY=0
            
    def moveLeft (self, dist, time):
        self.posX -= (dist * time)
        self.playerRect = self.playerRect.move(-(dist * time),0)
        
        if self.posX < 0:
            self.playerRect = self.playerRect.move(-(self.posX),0)
            self.posX = 0    
            
    def moveRight (self, dist, time):
        self.posX += (dist * time)
        self.playerRect = self.playerRect.move((dist * time),0)
        
        if self.posX > self.window_X - self.sizeX:
            self.playerRect = self.playerRect.move((self.window_X - self.sizeX) - self.posX,0)
            self.posX = self.window_X - self.sizeX
            
    # 
    def update(self):
        #self.moveDown(1,1)
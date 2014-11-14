#player ship class (could be extended to cover enemy movement

import pygame, sys

class Ship:

    def __init__(self, windowX, windowY):
        #Sprite (x, y) position
        self.posX = 100
        self.posY = 100
        #Sprite width and height
        self.sizeX = 32
        self.sizeY = 32
        #Size of the window
        self.window_X = windowX
        self.window_Y = windowY

        #Rectangle object representing the player
        self.playerRect = pygame.Rect(self.posX, self.posY, self.sizeX, self.sizeY)
        

    def moveDown (self, dist, time):
        self.posY += (dist * time)
        self.posY = min(self.posY, self.window_Y - self.sizeY)
        

    def moveUp (self, dist, time):
        self.posY -= (dist * time)
        self.posY = max(self.posY, 0)


    def moveLeft (self, dist, time):
        self.posX -= (dist * time)
        self.posX = max(self.posX, 0)


    def moveRight (self, dist, time):
        self.posX += (dist * time)
        self.posX = min(self.posX, self.window_X - self.sizeX)
        

    def update(self):
        '''Update the rect to match the player's position.
		'''
        self.playerRect.topleft = (self.posX, self.posY)
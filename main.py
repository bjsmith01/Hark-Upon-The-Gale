import pygame,sys
from pygame.locals import *
from Ship import *

windowX = 1000
windowY =600

ship = Ship(windowX,windowY)
ship2 = Ship(windowX-100,windowY-100)

ship3 = Ship(windowX - 200,windowY - 200)

shipList = [ship,ship2, ship3]

pygame.init() # this line starts pygame
mainClock=pygame.time.Clock()

windowSurface=pygame.display.set_mode((windowX,windowY))  # creates a window
tempSurface=windowSurface.subsurface(Rect(0,0,windowX,windowY)) # creates a temporary buffer tp draw images on
pygame.display.set_caption('Hark Upon THe Gale') # sets window name

RED=(255,0,0) # (Red, Green, Blue)
BLUE=(0,0,255) # (Red, Green, Blue)
WHITE=(255,255,255)

playingGame = True
moveLeft = False
moveRight = False
moveUp = False
moveDown = False

while playingGame:

    for event in pygame.event.get(): # poll for key presses
        if event.type == QUIT:
            pygame.quit()
            playingGame = False
            sys.exit()
        
        if event.type == KEYUP:
            if event.key == K_DOWN:
                #if state == playing
                moveDown = False
            if event.key == K_UP:
                moveUp = False 
            if event.key == K_LEFT:
                moveLeft = False
            if event.key == K_RIGHT:
                moveRight = False
        
        if event.type == KEYDOWN:
            if event.key == K_DOWN:
                moveDown = True
            if event.key == K_UP:
                 moveUp = True
            if event.key == K_LEFT:
                moveLeft = True
            if event.key == K_RIGHT:
                moveRight = True
                
    if moveUp:
        for ships in shipList:
            ships.moveUp(1,1)
        #ship.moveUp(1,1)
        #ship2.moveUp(1,1)
    if moveDown:
        for ships in shipList:
            ships.moveDown(1,1)
        #ship.moveDown(1,1)
        #ship2.moveDown(1,1)
    if moveLeft:
        for ships in shipList:
            ships.moveLeft(1,1)
        #ship.moveLeft(1,1)
        #ship2.moveLeft(1,1)
    if moveRight:
        for ships in shipList:
            ships.moveRight(1,1)
        #ship.moveRight(1,1)
        #ship2.moveRight(1,1)
        
    
    windowSurface.fill(WHITE) # colors over everything in window in white
        
    ''' Nothing is actually drawn to the screen unless you call blit or a draw command.  After you blit everything is put into a buffer.
        Once you call update the buffer is displayed on the screen'''

    for ships in shipList:
        pygame.draw.rect(tempSurface,RED,ships.playerRect) # draws a red rectangle at the top corner of the screen
    
    #pygame.draw.rect(tempSurface,BLUE,ship2.playerRect) # draws a red rectangle at the top corner of the screen

    windowSurface = tempSurface # tempSurface is a background buffer.  using backgrounds buffers is a more efficient way to display sprites

    if playingGame:
        pygame.display.update() # displays everthing that was drawn to the screen

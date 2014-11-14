import pygame,sys
from pygame.locals import *
from Ship import *

windowX = 1000
windowY = 600

ship = Ship(windowX, windowY)

pygame.init() # this line starts pygame
mainClock=pygame.time.Clock()

windowSurface=pygame.display.set_mode((windowX,windowY))  # creates a window
tempSurface=windowSurface.subsurface(Rect(0,0,windowX,windowY)) # creates a temporary buffer tp draw images on
pygame.display.set_caption('Pygame Test') # sets window name

#       (  r,  g,  b)
RED   = (255,  0,  0)
WHITE = (255,255,255)

playingGame = True
moveLeft    = False
moveRight   = False
moveUp      = False
moveDown    = False

while playingGame:
	
	mainClock.tick(60)

	for event in pygame.event.get(): # poll for key presses
		if event.type == QUIT:
			pygame.quit()
			playingGame = False
			sys.exit()
		
		if event.type == KEYUP:
			if event.key == K_DOWN:
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
		ship.moveUp(5,1)
	if moveDown:
		ship.moveDown(5,1)
	if moveLeft:
		ship.moveLeft(5,1)
	if moveRight:
		ship.moveRight(5,1)
		
	ship.update()
	windowSurface.fill(WHITE) # colors over everything in window in white
		
	''' Nothing is actually drawn to the screen unless you call blit or a draw command.  After you blit everything is put into a buffer.
		Once you call update the buffer is displayed on the screen'''

	pygame.draw.rect(tempSurface,RED,ship.playerRect) # draws a red rectangle at the top corner of the screen

	windowSurface = tempSurface # tempSurface is a background buffer.  using backgrounds buffers is a more efficient way to display sprites

	if playingGame:
		pygame.display.update() # displays everthing that was drawn to the screen
# APPROACH

Total time in development : (to be calculated)

---

## Session 001
### 120 mins

TODO
- Set up repo
- Readme file with updated description

DONE
- Readme file with updated description

---

## Session 002
### 4.05 -

TODO
- Unity project with simple motion and trail running at 60fps

DONE
- Add a framerate setting script to main camera
- Add a textbox to display framerate
- Framerate script added to canvas, framerate showing on device
- Framerate set to 120
- Framerate on player goes down to 60
- Getting errors about adaptive performance, starting a new project to see if it has the same
- Not sure about adapative performance, will come back to it
- add a canvas image with transparency, for trail effect
- Tried adding a trail effect component instead, didn't like it

---

## Session 003
### 150 mins

TODO
- Objet class
- Tap to add/remove objets

DONE
- Made an objet prefab
- Made a gamemanager prefab with a touchinput script
- Converted touches to worldspace
- Instantiate objet at touch
- Removed animator to have thrust and random rotation added each frame
- Removed rigidbody and thrust, swapped for transform.translate to see if it runs quicker with many objets
- Added an objet counter so I can see how many drop the framerate
- Around 65 objets the frame rate starts consistently dipping, so I might cap it at 50 to be safe for now
- By converting world to screen position for objets, can destroy them when they leave
- Refactoring logic to appropriate classes
- Counter updating when objets destroyed
- Hit over 100 instances without lagging
- Updated objet to borderless sprite
- Objets instantiated with a random rotation

![001](WIP/001.gif)

---

## Session 004
### 70 mins

TODO
- Tap to remove objets

DONE
- Click objets to destroy using button event
- Raycast from target to check collision, only create new objet if colliding with plane
- Gamemanager triggers object destruction instead of objet button
- Objet counter is updated correctly

---

## Session 005
### 180 mins

TODO
- Get midi input

DONE
- Installed new input system packages, set unity to use both
- Installed midi packages (https://github.com/keijiro/Minis) by modifying manifest file
- Set up action map with 1st rotary encoder (midi channel 3) bound to an AdjustMainValueEvent
- Objets are added and removed from a list on gamemanager
- Objets in list have their size updated by controller, but they spawn with zero scale for some reason
- Tried setting usb mode to midi on phone but not showing any change
- Tried changing touch handler but got stuck

---

## Session 006
### 80 mins

TODO
- Fix mainvalue reset issue or change to the legacy midi packages

DONE
- Changed touches to be triggered in new system
- New input system (midi) throwing errors on phone build

---

## Session 007
### 110 mins

TODO
- Test as windows application

DONE
- Lots of render glitches in player/exported app
- Tested new project with core render settings, no transparency glitches
- Will test midi, rebuild project if all good. Doesn't need to be on android, will try making it work later
- Midiinput and touch working in standalone windows build 
- Remake in new project

---

## Session 008
### 180 mins

TODO
- Continue rebuild as windows only
- Add objet selection

DONE
- Rearrange canvas and colliders
- Bring back objet destruction
- Gamemanager knows if objet/canvas are being held/tapped
- Added a list for selected objets
- Objets selected by holding
- Only selected objets are affected by value changes
- All objets are deselected by tapping canvas, or individually by holding
- Tried adjusting individual values, confusing maths
- Trail filter not working properly anymore
- Realised the trailer filter works differently in Unity than Processing, and colour is lost! Will either need a different implementation or go back and add midi to the processing version

---

## Session 009
### 75 mins

TODO
- Remake trail effect using render texture accumulation

DONE
- Tried using rendertextures in unity, too confusing
- For advancing this app, VVVV might be the best option. For now, I'm going to rebuild it in Processing

---

TODO
- Annotated controls diagram
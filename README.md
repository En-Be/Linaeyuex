# Linaeyeux

A color organ or light synthesizer (a machine/application for generating and performing lumia, or light music, through a novel interface) with features for graphism (the expression of abstract thought in material symbols).

*Linae is latin for line, yeux is french for light.*

Inspired by Thomas Wilfred and his clavilux, and Fry and his holophonor.

// Gif of screengrabs to go here

## User stories

```
As a user,
so I can see something unique,
I want to generate detailed and varied images over time
```

```
As a user,
so I can have a rich experience,
I want the interface to have deep potential for exploration and expression
```

```
As a user,
so I can have some control over what is generated,
I want to be able to change parameters
```

```
As a user,
so I can perform for an audience pieces I have practiced or improvised, 
I want only a subtle GUI or HUD, and/or a seperate window of controls with previews and value displays
```

```
As a user,
so I can have ergonomic access to all the controls,
I want a combination of touchscreen and midi controller input
```

```
As a user,
so I can have both fine tuning and powerful effect,
I want both individual attribute and global/macro control inputs
```

```
As a developer,
so I can extend the features and export to different platforms,
I want to port/remake the code from Processing to Unity
```

## Design

The imagery generated will be abstract (unless I later implement 3d model importing).

A scene is populated with objets:
- Create/destroy (tap)
- Select/deselect (hold/tap away)
- Paths and destinations (hold and drag)

Their destination defaults to where they were created. The player can change this by dragging in empty space. Destinations and objets can be set to leave the canvas/screen, or loop round to the opposite side.

Scales on each objet, which have their own values:
- Main value (normalized 1 < 100)
- Morph amount (how far from the main value can this scale change over time, negative and positive)
- Morph speed (the amount the main value changes each frame)
- Morph threshold (the amount the value has to change before it is actually shown)

Scales available for adjustment by holding relevant pad and turning knobs:
- Size (small < big)
- Hue (colour, cyclicle)
- Saturation (bleached < vibrant)
- Brightness (light < dark)
- Border vertices count (point < line < triangle < circle)
- Border vertices radius (random < symmetrical)
- Border shape (edges concave < edges convex)
- Movement towards destination (slow < fast)
- Fill (empty < full)
- Emit (never < every frame)
- Particle life (1 frame < infinite)
- Individuation (same as first objet in list < all values can morph to fully different. Not sure this is needed, other controls might allow it.)

If one or more objets are selected, changing a scale will affect them. If no objets are selected, all will be affected.

Macro controls:
- Morph amount (all main morph values simultaneously)
- Morph speed (all speed morph values simultaneously)
- Morph threshold (all threshold morph values simultaneously)

Global controls:
- Destination (hold in empty space)
- Borders (destroy or loop, switch)
- Remove all objets + particles (button)
- Timescale (knob)

Post effects:
- Ephemeral and persistent (trails)
- Mirror/kaleidescope
- Blur
- Chromatic Aberration

## User input

// Illustrated diagram to go here

## Notes

- Graphism began some 30,000 years BC, not as a photographic representation of reality but as an abstraction that was geared toward magical-religious matters. Early graphism then was a form of writing that constitutes a 'symbolic transposition'.

- Emergent significance. The percieved combination of scales over time adds up to meaning, like music, and apparent behaviour:

    https://www.youtube.com/watch?v=n9TWwG4SFWQ&list=PLJSMbjrrlXykip4zg-mwj6QuKD83Pr7TQ&index=149

    Played out in time, they can be seen as improvised/exploratory performances of story and expression.


- I've wanted to make a color organ for years, and previously designed a mechanical one. I was developing this for fun, and have picked it up again to have as a tool in persuing opportunities for live performance and work.
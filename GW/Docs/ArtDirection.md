# Guanche Warriors – Art Direction v0.1

## 1. Visual Goal

The game uses a detailed 32-bit-inspired pixel-art style combined with modern 2D presentation techniques in Unity.

The base artwork should remain clearly pixel-based, while Unity is used to enhance the presentation through:

- 2D lighting.
- Particle effects.
- Elemental effects.
- Atmospheric overlays.
- Glow and other subtle post-processing effects.
- Visual transitions between the physical and spiritual worlds.

The goal is to preserve the readability and identity of classic JRPG pixel art while giving the game a more modern visual presentation.

## 2. Base Resolution and Scale

Initial target sizes:

- Exploration character sprites: approximately 48x64 px.
- Battle character sprites: approximately 96x96 px.
- Environment tiles: 32x32 px.

These values are provisional but should be treated as the initial production standard so that characters, environments and future assets remain visually consistent.

## 3. Physical and Spiritual Worlds

The physical and spiritual worlds share the same basic environment geometry.

The spiritual version of a location should remain immediately recognizable, but its atmosphere changes through:

- Different color treatment.
- Lighting changes.
- Particle effects.
- Environmental overlays.
- Spiritual visual elements.
- Removal or alteration of normal-world details.

This approach allows locations to feel connected while reducing the need to create completely separate environments for both worlds.

## 4. Color Direction

The game uses a shared overall visual language so that all locations and characters belong to the same world.

However, each island should have its own secondary color identity.

This can be expressed through:

- Character accents.
- Transformation effects.
- Environmental lighting.
- Spiritual-world coloration.
- Elemental effects.
- UI or symbolic details when appropriate.

The goal is to create visual variety between islands without making them feel like they belong to different games.

## 5. Character Art Principles

### Body Proportions

All Warriors share a similar base body proportion and visual scale.

Differences between characters should come primarily from:

- Silhouette.
- Height.
- Build.
- Hairstyle.
- Clothing.
- Accessories.
- Weapons.

This keeps the cast visually cohesive while still allowing each Warrior to have a distinct identity.

### Exploration and Battle Sprites

Battle sprites are larger and more detailed versions of the exploration sprites.

The character design itself should remain consistent between both representations.

Initial target sizes:

- Exploration sprite: approximately 48x64 px.
- Battle sprite: approximately 96x96 px.

The battle version can use more detailed posing and animation, but should not significantly redesign the character.

### Transformations

Transformations preserve the Warrior's core identity while adding new visual layers and spiritual elements.

Transformation design may introduce:

- Additional armor.
- Layered clothing.
- Elemental effects.
- Spiritual symbols.
- Weapon evolution.
- Stronger silhouette details.

The transformed form should still clearly resemble the original character rather than becoming a completely different visual design.

### NPC Detail Level

NPCs use a simplified visual style compared with the main Warriors.

They should remain visually coherent with the world but require fewer unique details and less production time.

NPC design should prioritize:

- Clear silhouette.
- Readable role or occupation.
- Simple clothing variation.
- Limited animation requirements.

This allows the project to populate towns and locations without giving every secondary character the same production cost as a playable Warrior.

## 6. Environment Art

### Exploration Perspective

Exploration environments use a classic top-down perspective.

This approach is chosen to prioritize:

- Readability.
- Simpler tile production.
- Easier navigation.
- Faster implementation.

It also helps reduce complexity during environment creation and level design.

### Visual Density

Environments should remain clean and readable.

They should not be overloaded with decorative detail.

The priority is:

- Clear navigation.
- Easy interaction readability.
- Strong gameplay clarity.

Decorative elements can be added carefully, but should never interfere with readability.

### Architecture and Locations

Locations are inspired by real Canary Islands architecture and landscapes, but are stylized rather than recreated literally.

The goal is to preserve the essence of the Canary Islands while allowing:

- A stronger visual identity.
- More artistic freedom.
- Better adaptation to pixel art.
- Easier worldbuilding for fictional spiritual elements.

### Spiritual World

The spiritual world should use the same base geometry as the physical world.

At this stage, the transformation between both versions should be subtle.

Main differences should come from:

- Palette shifts.
- Lighting changes.
- Particles.
- Atmospheric effects.
- Small visual alterations.

This keeps locations recognizable while avoiding the production cost of building entirely separate maps.

### Interiors

Interiors should be simple and functional.

They exist to support gameplay and worldbuilding, but should not require excessive production effort.

The priority is to create:

- Readable spaces.
- Clear interaction points.
- Efficient reusable layouts.

### Tileset Strategy

The environment pipeline should use several reusable tileset kits rather than one fully unique tileset per island.

Possible reusable kits include:

- Urban
- Rural
- Volcanic
- Forest
- Coast
- Interiors

This approach offers:

- Better production efficiency.
- Greater flexibility.
- Easier asset reuse.
- Faster environment creation.

Regional identity can still be expressed by combining kits differently and using island-specific accents, props, lighting and palette choices.

## 7. Animation Scope

Animation should prioritize readability and production efficiency.

The goal is to provide enough motion to make characters and combat feel alive without creating an animation workload that becomes difficult to maintain during the first three months.

### Exploration Animations

Playable Warriors should initially include:

- Idle.
- Walk.
- Run.

Movement should support the required exploration directions.

Animation counts should remain relatively low and consistent between characters.

### Battle Animations

Each playable Warrior should initially include:

- Idle.
- Basic Attack.
- Skill.
- Hit.
- Defeat.
- Defend.
- Transform.

These animations represent the minimum required set for the first playable version.

More specific Skill animations can be introduced later if needed.

### Transformation Animation

Transformation sequences should combine limited sprite animation with Unity effects.

Rather than relying entirely on long frame-by-frame animation, transformations can use:

- A small number of dedicated sprite frames.
- Particle systems.
- Light flashes.
- Elemental effects.
- Screen effects.
- Sprite swaps.

This reduces art production cost while still allowing transformations to feel visually significant.

### Enemy Animations

Initial enemies should remain simple.

A basic enemy such as a slime should include:

- Idle.
- Attack.
- Hit.
- Defeat.

The first enemies are intended primarily to validate the combat system rather than demonstrate complex animation.

### NPC Animations

NPCs should generally include:

- Idle.
- Walk.

Animation sets should be reused across multiple NPCs whenever possible.

Visual variation should come mainly from:

- Clothing.
- Hair.
- Palette.
- Accessories.
- Small sprite changes.

This allows populated environments without requiring unique animation sets for every secondary character.
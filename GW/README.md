# Guanche Warriors – Game Design v0.1

## 1. High Concept
A 2D turn-based JRPG inspired by classic games of the genre, following eight young people connected to the Canary Islands who discover ancestral powers and gain the ability to transform into Guanche Warriors.

Throughout the adventure, the player gradually recruits the group while learning how to combine their different abilities, elemental affinities and combat roles. Transformations and turn-based strategy form the core of the gameplay experience.

The story connects the recent past with the pre-Hispanic history of the Canary Islands, using the archipelago's history, mythology and landscapes as the foundation for an original fantasy setting.

## 2. Player Fantasy
The player takes the role of a protagonist who discovers that he possesses an ancestral power and that he is not alone.

Throughout the adventure, he must find and unite the other Guanche Warriors, learn to master their transformations and combine each character's unique abilities in strategic turn-based battles.

## 3. Core Gameplay Loop

The game follows a mainly linear JRPG structure, with story-driven progression through different physical and spiritual locations across the Canary Islands.

### Exploration

The player explores relatively linear areas, interacts with NPCs and spiritual entities, finds items and equipment, and can discover optional paths or secrets.

Enemies are visible in the environment and can often be avoided.

Depending on the situation, the player may surprise an enemy, be surprised by it, or be ignored by weaker enemies when revisiting older areas.

When contact with an enemy triggers combat, the game transitions into a separate classic turn-based JRPG battle scene.

### Area Structure

A typical story area combines investigation and dungeon-like progression.

The player may:

1. Arrive at a location in the physical world.
2. Investigate a problem or unusual event.
3. Enter the spiritual plane.
4. Explore the spiritual version of the location.
5. Fight spiritual entities and discover items or secrets.
6. Progress through the area until reaching an important encounter or boss.
7. Resolve the main disturbance.
8. Return to the physical world and continue the story.

Some spiritual areas remain accessible after being completed and can be revisited later.

### Combat Rewards

## 6. Combat

Combat takes place in a separate classic JRPG battle scene after making contact with an enemy during exploration.

The active party can contain up to four Warriors.

### Turn Order

Turn order is visible to the player and is calculated primarily using each character's Speed stat.

The exact formula and whether some Skills can alter turn order will be decided later.

### Basic Commands

Each Warrior can choose from the following actions:

- Attack
- Skills
- Transform
- Item
- Defend
- Escape

### Basic Attack

Basic attacks are simple weapon-based actions.

A timing-based mechanic inspired by games such as The Legend of Dragoon may be explored later, but it is not part of the initial combat scope.

### Skills

All special techniques are grouped under a single Skills menu.

Skills can be:

- Physical
- Magical
- Support

All Skills consume energy from a shared Spiritual Pool.

### Spiritual Pool

The Spiritual Pool is a shared resource used by the whole active party.

At the beginning of combat, the pool starts full.

Using Skills reduces the pool.

The pool can gradually recover during combat through:

- Passive regeneration at the beginning of each round.
- Exploiting elemental weaknesses.
- Critical hits.
- Defending.
- Specific support Skills from certain Warriors.

At a narrative level, the Spiritual Pool represents the connection and shared energy between the Warriors.

Longer battles are intended to place greater pressure on resource management than shorter encounters.

### Elemental Affinities

Elemental strengths and weaknesses are an important part of combat strategy.

The final elemental system will use a limited group of recognizable elements, likely between five and eight.

Exploiting an enemy's elemental weakness:

- Deals increased damage.
- Generates more Transformation Gauge.

### Transformation Gauge

Each Warrior has an individual Transformation Gauge.

The gauge increases by:

- Performing effective attacks or combat actions.
- Receiving damage.
- Receiving damage while defending generates additional Transformation Gauge.

Once enough energy has been accumulated, the Warrior can transform.

The transformed state consumes Transformation Gauge over turns and remains active while energy is available.

The Transformation Gauge and Spiritual Pool are separate resources.

However, activating a transformation causes a strong release of individual spiritual energy, restoring a significant amount of the shared Spiritual Pool.

### Transformation Effects

While transformed, a Warrior:

- Receives increased combat stats, the highest stat increases more and the lowest decreases more too, increasing strenghts and weakneasses.
- Gains stronger elemental power.
- Can use a Final Technique.

The Final Technique can be activated at any moment during the transformation.

Using it immediately ends the transformed state.

### Defend

Defending reduces incoming damage.

If a Warrior receives attacks while defending, they generate additional Transformation Gauge.

This allows defensive Warriors to deliberately absorb enemy pressure and convert it into transformation energy.

Some tank-oriented Skills may allow a Warrior to attract enemy attacks before defending.

### Status Effects

Status effects are part of the combat system.

The initial version will begin with a limited set:

- Poison
- Burn

Additional status effects may be introduced later.

### Targeting

Skills can target:

- Individual allies or enemies.
- Multiple targets.

Targeting behavior depends on the Skill.

### Escape

The chance to escape from combat is influenced by the party's Speed relative to the enemies.

Boss battles cannot normally be escaped.

### Defeat and Retry

If the party is defeated, the player can choose between:

- Retrying the battle.
- Returning to the previous save point.

When retrying a boss battle, the party returns to the state and resources it had immediately before entering the encounter.

### Party

The active battle party can contain a maximum of four Warriors.

Once more than four Warriors have joined the group, the active party can normally be changed outside combat.

Some story battles may require specific Warriors to participate.

### Transformation

The first transformation of each Warrior is unlocked through the story.

Afterwards, transformation becomes a strategic combat resource.

Each Warrior has a transformation gauge that increases by:

- Performing effective attacks or combat actions.
- Receiving damage.

Once enough energy has been accumulated, the Warrior can transform.

The transformed state remains active while transformation energy is available and gradually consumes that energy over time.

Transformation is intended to be powerful but limited, preventing the player from relying on it permanently.

### Recovery and Defeat

Save points within spiritual areas restore the party's resources.

Completing certain spiritual areas and returning to the physical world can also fully restore the party.

If the entire party is defeated, the player can choose between:

- Retrying the battle.
- Returning to the previous save point.

## 4. World and Setting
### The Spiritual World

The physical world exists alongside an invisible spiritual plane.

Most people cannot perceive this plane directly, but disturbances within it can produce real consequences in the physical world.

Locations in the spiritual plane correspond to real places in the Canary Islands, but appear transformed, empty and influenced by spiritual energy.

Warriors are able to perceive and enter this plane after awakening their powers.

### The Awakening

A growing imbalance within the spiritual world causes the planet itself, provisionally referred to as "Gaia", to reactivate the ancient power of the Warriors.

Transformation objects that have remained dormant for generations begin to awaken.

The Tenerife Warrior is the first known Warrior of the modern era to transform.

### Spiritual Entities

The spiritual world is inhabited by entities connected to nature, memory and the ancient forces of the islands.

Most are not inherently evil.

However, the growing imbalance causes some of them to become corrupted, aggressive or unstable.

Their actions within the spiritual world produce consequences in the physical world.

### Relationship Bewtween Both Worlds

## 5. Main Characters
### Party Structure
The game follows one fixed main protagonist.

The player begins the story controlling this character and progressively recruits the other seven Guanche Warriors throughout the adventure.

This structure is intended to keep the narrative and development scope manageable while allowing the party and combat systems to grow progressively.

### Party Overview
| Isla | Warrior | Identidad visual / temática | Posible afinidad |
|---|---|---|---|
| Tenerife | Warrior de Tenerife | Teide, fuego, altura | 🔥 Fuego |
| Gran Canaria | Warrior de Gran Canaria | roca, montaña, resistencia | 🪨 Tierra |
| La Palma | Warrior de La Palma | volcanes, renacimiento | 🌋 Magma |
| Lanzarote | Warrior de Lanzarote | fuego, paisaje volcánico | 🔥/🖤 |
| Fuerteventura | Warrior de Fuerteventura | viento, desierto | 🌪️ Aire |
| La Gomera | Warrior de La Gomera | bosque, niebla, comunicación | 🌿 Naturaleza |
| El Hierro | Warrior de El Hierro | océano, aislamiento, misterio | 🌊 Agua |
| La Graciosa | Warrior de La Graciosa | mar, luz, libertad | ✨ Luz |

### 5.1 Main protagonist - Tenerife Warrior

**Gender:** Male

**Island:** Tenerife

**Combat role:** Balanced / versatile.

**Affinity:** Fire → Fire / Ice

He begins with fire as his main elemental affinity, representing Tenerife’s volcanic identity and the Teide.

Later in the story, he unlocks ice-based abilities connected to the snow and cold of the Teide, representing an evolution of both his powers and his understanding of his connection to the island.

**Character concept:**
An ordinary young man who unexpectedly discovers an ancestral power connected to Tenerife.

After the death of his grandfather, he goes to his house to collect his belongings and discovers a mysterious inherited object hidden among them.

The object acts as the catalyst for his transformation into the Tenerife Warrior.

Its exact form is still undecided. It could be a shell, an amulet, a ceremonial object, a weapon or another object linked to the island’s history and mythology.

Initially reluctant to accept the responsibility that comes with his powers, he gradually becomes the person capable of bringing the eight Warriors together.

**Character arc:**
From rejecting responsibility and doubting his ability to lead, to understanding that his real strength comes from trusting and uniting the other Warriors.

**Gameplay purpose:**
The protagonist introduces the player to the core combat mechanics before the other Warriors progressively add more specialized roles and abilities.

#### Grandfather and the Oral Legend

The protagonist's grandfather knew an old story that had been passed down orally through his family for generations.

The legend told of a Guanche warrior who played an important role during the conquest of Tenerife. However, according to the family tradition, his story was never formally recorded and was gradually lost from the historical narrative after the conquest and colonization of the island.

The grandfather believed the story had a historical origin, even if some parts had become legend over the centuries.

However, he did not know that the supernatural elements of the legend were real.

He also did not know that the object preserved by the family possessed any magical power or that it could trigger the transformation of a new Tenerife Warrior.

To him, the object was primarily a family heirloom connected to the legend.

### 5.2 The Second Warrior — La Palma

The second Warrior is a scientist working at an astronomical observatory in La Palma.

Through his professional work, he has encountered unusual data and unexplained phenomena that do not fit conventional scientific explanations.

While most of the scientific community dismisses these anomalies as errors, coincidences or irrelevant observations, he has continued investigating them privately.

Over time, he has collected information about strange events, recurring patterns and possible connections between different locations across the Canary Islands.

After the Tenerife Warrior's awakening, he detects a new anomaly and decides to investigate it.

He contacts the protagonist believing that he may be connected to the phenomena he has been studying.

At this point, he does not know that he is also a Warrior.

### Narrative Role

He acts as the group's early researcher and strategist.

His knowledge helps the protagonist begin to understand the spiritual world, although his explanations are initially based on investigation and hypothesis rather than complete knowledge.

### Combat Concept

His combat role is primarily support-oriented.

He is physically weaker than the protagonist and relies more heavily on:

- Support Skills.
- Magic.
- Buffs or debuffs.
- Tactical utility.

His exact elemental affinity, transformation object and weapon will be defined later.

## 6. Combat

Combat takes place in a separate classic JRPG battle scene after making contact with an enemy during exploration.

The active party can contain up to four Warriors.

### Turn Order

Turn order is visible to the player and is calculated primarily using each character's Speed stat.

The exact formula and whether some Skills can alter turn order will be decided later.

### Basic Commands

Each Warrior can choose from the following actions:

- Attack
- Skills
- Transform
- Item
- Defend
- Escape

### Basic Attack

Basic attacks are simple weapon-based actions.

A timing-based mechanic inspired by games such as The Legend of Dragoon may be explored later, but it is not part of the initial combat scope.

### Skills

All special techniques are grouped under a single Skills menu.

Skills can be:

- Physical
- Magical
- Support

All Skills consume energy from a shared Spiritual Pool.

### Spiritual Pool

The Spiritual Pool is a shared resource used by the whole active party.

At the beginning of combat, the pool starts full.

Using Skills reduces the pool.

The pool can gradually recover during combat through:

- Passive regeneration at the beginning of each round.
- Exploiting elemental weaknesses.
- Critical hits.
- Defending.
- Specific support Skills from certain Warriors.

At a narrative level, the Spiritual Pool represents the connection and shared energy between the Warriors.

Longer battles are intended to place greater pressure on resource management than shorter encounters.

### Elemental Affinities

Elemental strengths and weaknesses are an important part of combat strategy.

The final elemental system will use a limited group of recognizable elements, likely between five and eight.

Exploiting an enemy's elemental weakness:

- Deals increased damage.
- Generates more Transformation Gauge.

### Transformation Gauge

Each Warrior has an individual Transformation Gauge.

The gauge increases by:

- Performing effective attacks or combat actions.
- Receiving damage.
- Receiving damage while defending generates additional Transformation Gauge.

Once enough energy has been accumulated, the Warrior can transform.

The transformed state consumes Transformation Gauge over time and remains active while energy is available.

The Transformation Gauge and Spiritual Pool are separate resources.

However, activating a transformation causes a strong release of individual spiritual energy, restoring a significant amount of the shared Spiritual Pool.

### Transformation Effects

While transformed, a Warrior:

- Receives increased combat stats.
- Gains stronger elemental power.
- Can use a Final Technique.

The Final Technique can be activated at any moment during the transformation.

Using it immediately ends the transformed state.

### Defend

Defending reduces incoming damage.

If a Warrior receives attacks while defending, they generate additional Transformation Gauge.

This allows defensive Warriors to deliberately absorb enemy pressure and convert it into transformation energy.

Some tank-oriented Skills may allow a Warrior to attract enemy attacks before defending.

### Status Effects

Status effects are part of the combat system.

The initial version will begin with a limited set:

- Poison
- Burn

Additional status effects may be introduced later.

### Targeting

Skills can target:

- Individual allies or enemies.
- Multiple targets.

Targeting behavior depends on the Skill.

### Escape

The chance to escape from combat is influenced by the party's Speed relative to the enemies.

Boss battles cannot normally be escaped.

### Defeat and Retry

If the party is defeated, the player can choose between:

- Retrying the battle if it's a boss battle.
- Returning to the previous save point.

When retrying a boss battle, the party returns to the state and resources it had immediately before entering the encounter.
## 7. Transformations

Transformations are a central part of both the narrative and combat systems.

Each Warrior has a unique transformation linked to their island, ancestry, personal story and spiritual connection.

The transformed form is not a copy of an ancestor. Instead, it represents the current Warrior's own spiritual manifestation, shaped by ancestral power.

### Awakening

Each Warrior experiences an individual awakening moment.

These awakenings are story-driven and can happen in different ways depending on the character.

The first transformation is always introduced through the narrative before becoming available as a regular combat mechanic.

### Visual Identity

Transformations significantly change the Warrior's appearance.

This may include:

- New clothing or armor.
- Changes in silhouette.
- Spiritual or elemental effects.
- A transformed or manifested weapon.

Visual evolution is limited and only happens at important narrative milestones.

Each Warrior's transformed appearance may change one or two times during the entire game, usually alongside major armor upgrades.

### Transformation Objects

Each Warrior has a unique transformation object connected to their island, ancestry or personal history.

The object does not always become the weapon directly, but there must be a clear thematic relationship between both.

For example, a transformation object connected to the sea, such as a shell, could manifest a weapon inspired by fishing or maritime symbolism.

### Weapons

Weapons are unique to each Warrior.

Their transformed weapon should reflect the Warrior's identity, elemental affinity and transformation object.

The exact relationship between object and weapon can vary between characters.

### Transformation Gauge

Each Warrior has an individual Transformation Gauge.

Once enough energy has been accumulated, the Warrior can spend their turn transforming.

Transformation does not grant an immediate extra action.

While transformed:

- Combat stats are increased.
- Elemental affinity is strengthened.
- Existing Skills benefit from the improved stats and elemental power.
- One or two exclusive transformation Skills become available.
- A Final Technique becomes available.

### Duration

Transformation consumes energy every turn.

Certain exclusive actions may consume additional Transformation Gauge.

When the gauge reaches zero, the Warrior automatically returns to normal form.

There is no additional penalty for returning to normal form.

Multiple Warriors can be transformed at the same time.

### Spiritual Pool Interaction

The Transformation Gauge and the shared Spiritual Pool are separate resources.

However, activating a transformation releases a burst of individual spiritual energy that restores a significant amount of the shared Spiritual Pool.

This creates a connection between individual power and the strength of the group.

### Final Techniques

A transformed Warrior can activate a Final Technique at any point.

Using a Final Technique immediately ends the transformation.

Different Final Techniques may behave differently.

The initial Final Technique can have a fixed effect, while a later Final Technique unlocked through armor progression may scale depending on the amount of Transformation Gauge remaining when activated.

### Transformation Sequence

The first transformation of each Warrior uses a full transformation sequence.

Afterwards, a shorter version is used during regular battles to maintain combat pacing.

### Narrative Restrictions

Transformations are primarily used in the spiritual world, where normal combat takes place.

However, the story may include specific exceptions where transformation becomes possible or relevant in the physical world.

### Group Transformation

The eight Warriors may eventually perform a special combined transformation or group attack.

This is intended as a scripted narrative moment rather than a regular combat mechanic.

### Transformation Objects

Each Warrior may have a different transformation object linked to their island, ancestry or personal story.

These objects should not only serve as transformation devices, but also as narrative symbols connected to each character.

## 8. Progression

Character progression is structured around several separate systems:

- Experience and Level.
- Skill unlocks and upgrades.
- Passive abilities.
- Weapons.
- Armor.
- Accessories.
- Story-based transformation progression.

### Experience and Level

Warriors gain Experience Points through combat.

Leveling automatically increases character stats.

The initial core stats are:

- HP
- Attack
- Defense
- Magic
- Resistance
- Speed
- Luck

The exact function of Luck will be defined later. Possible uses include critical hit chance, drop quality or other probability-based effects.

All recruited Warriors receive the same amount of Experience, even when they are not part of the active battle party.

This allows the player to change party composition freely without heavily penalizing characters that have not been used recently.

### Skill Unlocks

Skills are unlocked automatically at specific character levels.

Each Warrior has their own predefined Skill progression.

The player does not manually choose which Skills to unlock.

Whether future Skills are visible before they are unlocked or remain hidden until reaching the required level will be decided later.

### Spiritual Energy Progression

Spiritual Energy earned through combat is accumulated outside battle.

The player can decide when and how to spend it.

Spiritual Energy can be used to:

- Upgrade already unlocked Skills.
- Unlock passive abilities.

Each Skill has a small predefined upgrade path, generally containing two or three upgrades.

These upgrades may improve different aspects of the Skill depending on its design.

### Passive Abilities

Passive abilities are unlocked using Spiritual Energy.

Once unlocked, passive abilities remain permanently active.

Passive progression can differ between Warriors depending on their combat role.

### Weapons

Each Warrior uses weapons exclusive to that character.

New weapons are mainly obtained through story progression rather than random drops or frequent equipment replacement.

Weapons increase specific stats and may emphasize different aspects of a Warrior.

For example, one weapon may favor physical Attack while another favors Magic.

Some weapons may also unlock or improve a specific Skill.

### Armor

Armor progression is highly limited and tied to major story events.

Each Warrior receives only a small number of significant armor upgrades throughout the game.

Armor upgrades:

- Change the visual appearance of the Warrior's transformation.
- Unlock a new Final Technique.

These upgrades represent major narrative and power progression milestones.

### Accessories

Each Warrior can equip one accessory.

Accessories are interchangeable between Warriors.

The total number of accessories is intentionally limited.

Accessories mainly modify character stats rather than introducing large additional systems.

### Transformation Progression

Transformation strength is not upgraded using Spiritual Energy.

Major transformation improvements are tied to story and armor progression.

This keeps transformation evolution connected to narrative milestones rather than grinding.

### Progression Control

Character progression is mainly controlled through story progression.

The game is not designed around unrestricted grinding or over-leveling.

Optional training areas may be introduced later to allow limited additional progression when needed.

The exact Level Cap will be decided later.

## 9. Story Structure

### Opening

The story begins after the death of the protagonist's grandfather.

While going through his grandfather's belongings, the protagonist discovers the mysterious family object connected to the old oral legend.

Shortly afterwards, a spiritual entity attacks.

The object reacts to the threat and triggers the protagonist's first transformation into the Tenerife Warrior.

### Initial Conflict

After the first encounter, the protagonist's immediate goal is to understand what has happened to him and what the spiritual entities are.

He initially has very little knowledge of the spiritual world or the meaning of his transformation.

### The Second Warrior

The second Warrior is an investigator who has already been researching unusual spiritual phenomena, ancient traditions and unexplained events.

Unlike the protagonist, this character actively seeks him out after detecting or learning about his awakening.

They become the main source of early information about the spiritual world and help introduce the player to the wider lore.

Their combat role is more support-oriented and they are physically weaker than the protagonist.

Their personality is intelligent, curious and analytical, with a role within the group similar to the "researcher / strategist" archetype.

### Recruiting the Warriors

The eight Warriors are recruited in a fixed narrative order.

However, their recruitment situations are not identical.

Some may:

- Be discovered in the physical world.
- Need to be rescued from the spiritual world.
- Join after their own awakening.
- Be recruited alongside another Warrior during the same story arc.

The exact recruitment sequence will be defined later.

### Overall Structure

The story will not strictly follow a "one island = one chapter" structure.

Different islands, characters and spiritual conflicts may overlap throughout the narrative.

The main story gradually expands from the protagonist's personal awakening into a larger conflict involving the spiritual imbalance affecting the entire archipelago.

## 10. First Playable Version

The first playable version is focused on validating the core gameplay systems rather than presenting a complete narrative experience.

### Playable Content

The player must be able to:

- Move the main protagonist through an exploration area.
- Interact with at least one NPC.
- Enter the spiritual world.
- See enemies directly in the environment.
- Trigger a separate JRPG-style battle scene by making contact with an enemy.
- Gain Experience after combat.
- Use Skills.
- Build and activate the Transformation Gauge.
- Transform during combat.

### Playable Characters

The first version includes two playable Warriors:

- Tenerife Warrior.
- La Palma Warrior.

This allows the prototype to test two different combat roles:

- A balanced / versatile character.
- A support-oriented character.

### Combat Content

The prototype contains several small combat encounters.

The goal is not to create a full dungeon or boss encounter yet, but to validate:

- Turn order.
- Basic attacks.
- Skills.
- Shared Spiritual Pool.
- Elemental weaknesses.
- Transformation Gauge.
- Transformation.
- Experience rewards.

### Narrative Scope

The first playable version does not require finished story content.

Dialogue, NPC interaction and transitions between the physical and spiritual worlds may use temporary text and placeholder content.

The priority is validating gameplay functionality and the connection between exploration and combat.
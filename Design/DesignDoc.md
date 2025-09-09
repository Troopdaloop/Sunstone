# Sunstone Game Design Document

## 🎮 Game Overview
- **Title**: Sunstone
- **Genre**: 2D Action / Arena
- **Modes**:
  - Mode 1: Random Waves + Loot
  - Mode 2: Set Waves + High Score
  - Mode 3: Equipment Selection
- **Ultimate Reward**: The Sunstone

---

## 🧱 Mode 1: Adventure - Random Waves + Randomised Loot

### Enemy Wave Logic
- Wave Number: [ ]
- Enemy Types: [Goblin, Skeleton, Orc]
- Spawn Rate: [ ] per second
- Wave Duration: [ ] seconds
- Difficulty Scaling: [Health +10%, Speed +5% per wave]

### Loot Table Example
**Enemy: Skeleton**
- Rusty Sword (10%)
- Iron Helm (5%)
- Health Potion (20%)

**Loot Rarity Tiers**
- Common
- Rare
- Epic
- Legendary

---

## 🧱 Mode 2: Challenge Set Waves + High Score + rewards (Loot)
### Wave Setup
**Wave 1**
- 3 Goblins
- 1 Skeleton
- Spawn Times: 0s, 5s, 10s

**Wave 2**
- 2 Orcs
- 1 Goblin Archer
- Spawn Times: 15s, 20s
### Scoring System
- Kill = +10 pts
- Combo = +5 pts per enemy
- Time Bonus = +50 pts if wave cleared under 30s

### Rewards
- Score > 1000 = Silver Chest
- Score > 2000 = Gold Chest
- Score > 3000 = Sunstone Fragment

---

## 🧱 Mode 3: Equipment Selection

### Inventory Slots
- Weapon
- Helm
- Chest Armour
- Boots
- Trinket

### Example Equipment
**Iron Sword**
- Damage: +10
- Speed: -1

**Sunstone**
- Damage: +50
- Special: Fire Aura

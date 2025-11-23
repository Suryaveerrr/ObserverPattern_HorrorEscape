# 👁️ Observer Pattern: Horror Escape

![Unity](https://img.shields.io/badge/Unity-2021.3%20LTS-black?style=flat&logo=unity)
![Pattern](https://img.shields.io/badge/Design%20Pattern-Observer-blueviolet)
![Language](https://img.shields.io/badge/C%23-Delegates%20%26%20Events-blue)

> **A technical demonstration of loosely coupled architecture using C# Events, Actions, and Delegates.**

This project is a short horror game designed specifically to implement the **Observer Pattern**. Instead of direct dependencies (spaghetti code), the game uses an event-driven system where objects "broadcast" changes, and unrelated systems "listen" and react accordingly.

---

## 📸 Gallery

| Environment | Interaction | Atmosphere |
| :---: | :---: | :---: |
| ![Dark Room](https://github.com/user-attachments/assets/28b52908-7866-4acb-b5c7-d4bc97f9be4c) | ![Key System](https://github.com/user-attachments/assets/2a69760d-04d3-48eb-bdf3-b8e62f5204d1) | ![Events](https://github.com/user-attachments/assets/1c372c8c-6abc-4750-b10d-d94313209efd) |

---

## 🏗️ System Architecture

The core goal of this project was to move away from hard references (`public GameObject otherObject`) and utilize a scalable **Event Bus** approach.

### The Observer Implementation
1.  **Broadcasters (Subjects):** Triggers in the world (like picking up a key or entering a room) invoke C# `Actions` or `Events`. They do not know *what* will happen, only that *something* happened.
2.  **Listeners (Observers):** Systems like the `AudioManager`, `LightingManager`, and `GameManager` subscribe to these events.
3.  **Decoupling:** This allows purely modular scripts. The lighting system can be deleted entirely, and the key pickup logic will still work without throwing a `NullReferenceException`.

---

## 🎮 Features

* **Event-Driven Scares:** Horror events (lights flickering, sounds playing, jump scares) are triggered via custom event broadcasters.
* **Progression System:** A "3-Key" collection loop that unlocks the escape route.
* **Modular Interaction:** Scripts are designed to be reusable across different triggers without tight coupling.
* **Scene Management:** Clean transitions between the Main Menu, Gameplay, and Win states.

---

## 💻 Tech Stack & Concepts

| Category | Technology Used |
| :--- | :--- |
| **Engine** | Unity 2021.3.21f1 LTS |
| **Pattern** | **Observer Pattern** |
| **C# Concepts** | `Action`, `Func`, `delegate`, `event` keyword |
| **UI** | Unity UI System (Canvas) |

---

## 🎯 Learning Objectives

This project was built to master the following technical skills:
* ✅ **Decoupling Code:** Implementing systems that communicate without direct references.
* ✅ **C# Deep Dive:** Practical application of Delegates vs. Actions vs. Events.
* ✅ **Scalability:** Creating an architecture where adding new horror events doesn't require rewriting existing code.

---

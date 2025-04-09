# Aviation_Software
### This is a simulation of an Aviation Software System that uses design patterns to manage aircraft operations like engine control, autopilot, and altitude tracking. It demonstrates how pilots interact with key systems and how those systems react dynamically based on altitude conditions.

#### ✈️ Overview
The software enables pilots to issue commands and receive automatic system responses at different altitudes, simulating real-world cockpit behavior. The system applies core Object-Oriented Programming (OOP) principles and utilizes the Command, Observer, and Singleton design patterns.

#### 🔧 Pilot Commands
The pilot can perform the following actions:

🔄 Start Engines

🤖 Turn Autopilot ON/OFF

🛬 Deploy or retract Landing Gears

These commands are encapsulated using the Command Pattern, providing a clean way to execute and manage pilot operations.

📡 Altitude Monitoring & Automatic Actions
📉 At lower altitudes:

Autopilot is automatically activated

Engine power is increased

Alarm notifies the pilots

📈 At higher altitudes:

Autopilot is automatically activated

Engine power is decreased

Alarm notifies the pilots

The system monitors altitude continuously and uses the Observer Pattern to notify dependent components like Engine, Autopilot, and Alarm.

#### 👥 Design Patterns Used
🧭 Command Pattern
Used for managing pilot commands such as engine start, autopilot toggling, and landing gear control.

✅ Benefits:
Decouples command issuance from execution

Enables command queuing, logging, or undo functionality

🔄 Observer Pattern
Used for monitoring and responding to altitude changes in real-time. The Altitude subject notifies observers when values change.

✅ Observers:
Engine

Autopilot

Alarm

🔐 Singleton Pattern
Ensures that only one instance of the Air Traffic Controller exists for communication with pilots, maintaining security and global access.

 
 
 

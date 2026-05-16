# Custom Queue Implementation Using Doubly Linked List

This project represents an engineering application to build a custom Queue data structure from scratch. It falls under the category of **Functional Systems**, designed as a wrapper layout that leverages a pre-built Doubly Linked List to implement advanced queue behaviors, making it highly reusable for systems requiring structured linear data management.

This advanced educational system was developed under the supervision and guidance of the esteemed engineer: **Mohammed Abu-Hadhoud** via [Programming Advices](https://programmingadvices.com/courses/enrolled/2001432).

---

## 📌 System Overview

The system is a Generic Template Class (`clsMyQueue`) built in C++ that extends the capabilities of a traditional Queue. Instead of being restricted to standard FIFO (First-In, First-Out) constraints, this system utilizes an underlying Doubly Linked List (`_MyList`). This architecture provides the developer with additional flexibility to manipulate, update, reverse, and inject elements anywhere inside the queue while maintaining optimal memory performance.

---

## 🛠️ System Features

The system contains a comprehensive package of operations and functions covering all data manipulation needs within the queue:

### 1. Core Queue Operations
* **Push Item:** Adds a new element to the end of the queue via the function `push(T Item)`.
* **Pop Item:** Safely removes the oldest element from the front of the queue via the function `pop()`.
* **Clear Queue:** Deallocates all elements inside the queue and resets its state via the function `Clear()`.

### 2. Custom Extension & Insertion Operations
* **Insert at Front:** Injects a new element directly at the beginning of the queue via the function `InsertAtFront(T Value)`.
* **Insert at Back:** Appends a new element at the very end of the queue via the function `InsertAtBack(T Value)`.
* **Custom Insertion After Index:** Injects an element at a specific position after a given index via the function `InsertAfter(int Index, T NewValue)`.

### 3. Access, Search & Control
* **Front Access:** Retrieves the value of the first element in the queue via the function `front()`.
* **Back Access:** Retrieves the value of the last element in the queue via the function `back()`.
* **Access Value by Index:** Retrieves the value of any element based on its position via the function `GetItem(int Index)`.
* **Update and Modify:** Updates the value of an existing element at a specific position via the function `UpdateItem(int Index, T NewValue)`.
* **Reverse Queue:** Completely flips the order of the elements inside the queue via the function `Reverse()`.
* **Size Monitoring & Checking:** Immediate functions to determine the current number of elements via the function `Size()` and check if the queue is empty via the function `IsEmpty()`.
* **Print Queue:** Displays all elements sequentially on the screen via the function `Print()`.

---

## 💻 Code Architecture

Responsibilities within this **Functional System** are divided through structural encapsulation and code reuse principles:

* **Protected Storage Layout & Composition (`_MyList`):** Here, we applied the **Composition** principle by embedding an instance of `clsDblLinkedList<T>` as an internal protected member. This structural design enables the system to reuse the list's robust features, allowing for potential future inheritance while successfully hiding raw pointer manipulation details from the end-user.
* **Public Interface:** Exposes clean, high-level functions that encapsulate the underlying linked list methods, presenting them as an enhanced queue workflow.

---

## 🎯 Engineering Deliverables

Developing this system ensures a deep understanding of several advanced programming concepts:
* **The Wrapper Design Pattern:** Reusing existing low-level structures to build high-level abstract data types efficiently.
* **Generic Programming:** Keeping the business logic generic to support multiple data types seamlessly.
* **Data Layer Protection:** Controlling access boundaries through proper encapsulation and class access specifiers.

---

## 🚀 Technologies Used

* **C++11 / C++17**
* **OOP Concepts (Encapsulation & Architecture)**
* **C++ Templates (Generic Programming)**
* **Composition & Code Reuse Principles**

================================================================================

# بناء طابور مخصص باستخدام القائمة المتصلة المزدوجة

هذا المشروع يمثل تطبيقاً هندسياً لبناء هيكل بيانات الطابور المخصص (Queue) من الصفر، وهو يندرج تحت تصنيف **Functional Systems** حيث تم تصميمه كغلاف برمجى يعتمد على كلاس القائمة المتصلة المزدوجة المبني مسبقاً، لتوفير نظام طابور متطور وقابل لإعادة الاستخدام في الأنظمة البرمجية المختلفة.

تم تطوير هذا النظام التعليمي المتقدم تحت إشراف وتوجيه المهندس القدير: **محمد أبو هدهود** عبر [Programming Advices](https://programmingadvices.com/courses/enrolled/2001432).

---

## 📌 عن النظام (System Overview)

النظام عبارة عن فئة قالب عامة (`clsMyQueue`) تم بناؤها بلغة C++، لتوسيع وتحسين قدرات الطابور التقليدي. بدلاً من الالتزام القياسي بآلية FIFO (الداخل أولاً يخرج أولاً) فقط، يرتكز هذا النظام على كلاس القائمة المتصلة المزدوجة (`_MyList`). تمنح هذه البنية المطور مرونة إضافية للتعديل، التحديث، العكس، والإدراج في أي مكان داخل الطابور مع الحفاظ على كفاءة إدارة الذاكرة.

---

## 🛠️ المميزات والوظائف البرمجية (System Features)

يحتوي النظام على حزمة متكاملة من العمليات والوظائف التي تغطي كافة احتياجات التعامل مع البيانات داخل الطابور:

### 1. عمليات الطابور الأساسية (Core Queue Operations)
* **إضافة عنصر:** إدراج عنصر جديد في نهاية الطابور عبر الدالة `push(T Item)`.
* **سحب عنصر:** إزالة العنصر الأول والأقدم من مقدمة الطابور عبر الدالة `pop()`.
* **تنظيف الطابور كاملاً:** تفريغ الذاكرة وإزالة جميع العناصر دفعة واحدة عبر الدالة `Clear()`.

### 2. عمليات الإدراج والتوسعة المخصصة (Custom Insertion)
* **الإضافة في المقدمة:** إدخال عنصر جديد مباشرة في أول الطابور عبر الدالة `InsertAtFront(T Value)`.
* **الإضافة في المؤخرة:** إدخال عنصر جديد في آخر الطابور عبر الدالة `InsertAtBack(T Value)`.
* **الإدراج المخصص بعد دليل:** إمكانية إضافة عنصر جديد بعد رقم دليل محدد عبر الدالة `InsertAfter(int Index, T NewValue)`.

### 3. عمليات الاستعلام والتحكم (Access & Control)
* **الوصول للمقدمة:** جلب قيمة أول عنصر في الطابور عبر الدالة `front()`.
* **الوصول للمؤخرة:** جلب قيمة آخر عنصر في الطابور عبر الدالة `back()`.
* **الوصول للقيمة بالدليل:** جلب قيمة أي عنصر محدد بناءً على موقعه عبر الدالة `GetItem(int Index)`.
* **التحديث والتعديل:** تعديل قيمة عنصر موجود بالفعل في موقع معين عبر الدالة `UpdateItem(int Index, T NewValue)`.
* **عكس الطابور:** إعادة ترتيب عناصر الطابور بالكامل وعكس اتجاهها عبر الدالة `Reverse()`.
* **مراقبة الحجم والفحص:** دوال فورية لمعرفة عدد العناصر الحالية عبر الدالة `Size()` وفحص ما إذا كان الطابور فارغاً أم لا عبر الدالة `IsEmpty()`.
* **طباعة الطابور:** عرض جميع عناصر الطابور بشكل متسلسل في الشاشة عبر الدالة `Print()`.

---

## 💻 هيكلية الكود البرمجي (Code Architecture)

تم تقسيم وتوزيع المسؤوليات داخل هذا الـ **Functional System** من خلال مبدأ الكبسلة الهيكلية وإعادة استخدام الكود:

* **مخزن البيانات المحمي وتطبيق مبدأ الكومبيزشن (`_MyList`):** هنا قمنا بتطبيق مبدأ التركيب (**Composition**) عن طريق تضمين كائن من `clsDblLinkedList<T>` كعنصر داخلي محمي (Protected)، لإتاحة إمكانية التوريث مستقبلاً مع حجب تفاصيل المؤشرات المعقدة عن المستخدم النهائي والاستفادة الكاملة من وظائف القائمة المتصلة.
* **الواجهة العامة الفعالة (Public Interface):** توفر للمطورين دالات عالية المستوى تغلف وتدير عمليات القائمة المتصلة وتظهرها بأسلوب عمل الطابور المطور.

---

## 🎯 الأهداف والمكتسبات الهندسية (Engineering Deliverables)

تطوير هذا النظام يضمن تحقيق فهم عميق لعدة مفاهيم برمجية متقدمة:
* **نمط التصميم الغلافي (Wrapper Design Pattern):** إعادة استخدام هياكل بيانات منخفضة المستوى لبناء أنواع بيانات مجردة وعالية المستوى بكفاءة.
* **البرمجة العامة (Generic Programming):** إبقاء منطق النظام مرناً ليدعم مختلف أنواع البيانات دون إعادة كتابة الكود.
* **حماية مستويات البيانات:** التحكم في حدود الوصول البرمجي من خلال استخدام محددات الوصول المناسبة للـ OOP.

---

## 🚀 لغات وتقنيات مستخدمة

* **C++11 / C++17**
* **OOP Concepts (Encapsulation & Architecture)**
* **C++ Templates (Generic Programming)**
* **Composition & Code Reuse Principles**

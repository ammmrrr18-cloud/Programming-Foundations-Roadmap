# Custom Stack Implementation via Inheritance and Template Polymorphism

This project represents an advanced engineering application to build a custom Stack data structure from scratch. It falls under the category of **Functional Systems**, designed by implementing class inheritance from a pre-built Queue system, showcasing optimal code reuse, pointer handling via the `this` keyword, and LIFO (Last-In, First-Out) behavior optimization.

This advanced educational system was developed under the supervision and guidance of the esteemed engineer: **Mohammed Abu-Hadhoud** via [Programming Advices](https://programmingadvices.com/courses/enrolled/2001432).

---

## 📌 System Overview

The system is a Generic Template Class (`clsMyStack`) built in C++ that inherits directly from `clsMyQueue<T>`. By leveraging inheritance, this system transforms the linear behavior of the queue into a fully functional Stack. A key engineering highlight of this implementation is the explicit use of the `this->` pointer, which resolves template dependent name lookups cleanly and ensures high compatibility across modern C++ compilers.

---

## 🛠️ System Features

The system adapts and optimizes the underlying doubly linked list methods to enforce clean stack semantics:

### 1. Core Stack Operations
* **Push Item:** Injects a new element at the very beginning of the underlying structure via the function `push(T Item)`, utilizing `this->_MyList.InsertAtBeginning(Item)` to maintain the LIFO memory structure efficiently.
* **Pop Item:** Inherits the capability to remove elements sequentially via the inherited `pop()` method.

### 2. Element Access & Inspection
* **Top Access:** Retrieves the current element sitting at the top of the stack via the function `Top()`, which cleanly redirects to `this->front()`.
* **Bottom Access:** Retrieves the deepest element at the very bottom of the stack via the function `Bottom()`, redirecting directly to `this->back()`.

---

## 💻 Code Architecture

Responsibilities within this **Functional System** demonstrate pure object-oriented architecture, strategic inheritance, and functional polymorphism:

* **The Inheritance Layer & Structural Logic (`public clsMyQueue<T>`):** Fundamentally, a Stack is conceptually very similar to a Queue as they share almost identical behavioral characteristics, with the definitive difference being that a Queue enforces **FIFO** (First-In, First-Out) while a Stack enforces **LIFO** (Last-In, First-Out). To elegantly resolve this, we utilized **Inheritance** instead of Composition. By inheriting the entire Queue infrastructure and performing a clean method **Override** on the `push(T Item)` function, we completely eliminated code duplication. This architectural choice represents the optimal engineering solution for this layout.
* **The Explicit Context Pointer (`this->`):** Employing `this->` ensures strict template bound resolution during compile-time, acting as a clean code convention for dependent member access in generic programming.

---

## 🎯 Engineering Deliverables

Developing this system ensures a deep understanding of several advanced programming concepts:
* **Template Inheritance Challenges:** Mastering how compilers resolve template scope and using the explicit `this` context to write robust code.
* **The LIFO Mechanism via Re-Purposing:** Re-routing existing linked list operations to build a top-performing stack layout.
* **Code Reusability & DRY Principle:** Extending code bases elegantly without duplication through proper class hierarchies.

---

## 🚀 Technologies Used

* **C++11 / C++17**
* **OOP Concepts (Inheritance, Polymorphism & Scope Resolution)**
* **C++ Templates & Generic Programming**
* **Template Bound Resolution & Contextual Pointers (`this->`)**

================================================================================

# بناء مكدس مخصص عن طريق التوريث وقوالب تعدد الأشكال

هذا المشروع يمثل تطبيقاً هندسياً متقادماً لبناء هيكل بيانات المكدس (Stack) من الصفر، وهو يندرج تحت تصنيف **Functional Systems** حيث تم تصميمه عن طريق تطبيق مبدأ التوريث من نظام الطابور (Queue) المبني سابقاً، لاستعراض الكفاءة العالية في إعادة استخدام الكود، والتحكم في المؤشرات الديناميكية عبر الكلمة المفتاحية `this`.

تم تطوير هذا النظام التعليمي المتقدم تحت إشراف وتوجيه المهندس القدير: **محمد أبو هدهود** عبر [Programming Advices](https://programmingadvices.com/courses/enrolled/2001432).

---

## 📌 عن النظام (System Overview)

النظام عبارة عن فئة قالب عامة (`clsMyStack`) تم بناؤها بلغة C++، حيث ترث مباشرة من كلاس الطابور `clsMyQueue<T>`. من خلال توظيف علاقة التوريث (Inheritance)، يقوم هذا النظام بتحويل السلوك الخطي للطابور ليحاكي تماماً وظائف المكدس بآلية LIFO (الداخل أخيراً يخرج أولاً). وتكمن الميزة الهندسية البارزة هنا في الاستخدام الصريح للمؤشر `this->` لحل مشكلة التعرف على أسماء الدوال الموروثة داخل القوالب وتأمين استقرار الكود أثناء الترجمة.

---

## 🛠️ المميزات والوظائف البرمجية (System Features)

يقوم النظام بتكييف دالات القائمة المتصلة المزدوجة الأساسية لفرض خصائص المكدس بأعلى كفاءة:

### 1. عمليات المكدس الأساسية (Core Stack Operations)
* **إضافة عنصر (Push):** إدراج عنصر جديد في أعلى المكدس (مقدمة البنية التحتية) عبر الدالة `push(T Item)` بالاعتماد الكامل على `this->_MyList.InsertAtBeginning(Item)`.
* **سحب عنصر (Pop):** يرث المكدس القدرة على إزالة العناصر تباعاً وبأمان عبر دالة `pop()` المستدعاة من الكلاس الأب.

### 2. عمليات الاستعلام والوصول (Element Access)
* **الوصول للأعلى (Top):** جلب قيمة العنصر الحالي الموجود على قمة المكدس عبر الدالة `Top()` والتي تقوم بالتوجيه الداخلي الذكي إلى `this->front()`.
* **الوصول للأسفل (Bottom):** جلب قيمة العنصر الأعمق الموجود في قاع المكدس عبر الدالة `Bottom()` والتوجيه المباشر إلى `this->back()`.

---

## 💻 هيكلية الكود البرمجي (Code Architecture)

تم تقسيم وتوزيع المسؤوليات داخل هذا الـ **Functional System** بالاعتماد على التوريث الصريح وفصل النطاقات:

* **طبقة التوريث والمنطق الهيكلي (`public clsMyQueue<T>`):** من الناحية الهندسة البرمجية، المكدس (Stack) يتشابه تماماً مع الطابور (Queue) في الخصائص والوظائف الداخلية، ولكن الفارق الجوهري الوحيد يكمن في أن الطابور يطبق مبدأ **FIFO** (الداخل أولاً يخرج أولاً) بينما المكدس يطبق مبدأ **LIFO** (الداخل أخيراً يخرج أولاً). بناءً على ذلك، قمنا هنا بتطبيق مبدأ **التوريث (Inheritance)** بدلاً من الكومبيزشن (Composition)؛ حيث ورثنا بنية الطابور بالكامل وقمنا بعمل **Override** مخصص لدالة الإضافة `push(T Item)` لتغير سلوك الإدخال، وذلك لتجنب تكرار الكود والدوال المشتركة (مثل الحجم، الفحص، والتنظيف)، وهذا هو الحل الهندسي الأمثل والأكثر كفاءة لتصميم هذا النظام.
* **الربط الصريح للمؤشر السلوكي (`this->`):** يضمن استخدام `this->` توجيه الكومبيلر وفك الارتباط المبهم للمتغيرات والدوال الموروثة داخل القوالب الجينيريك، مما يرفع من جودة ونظافة التصميم الهيكلي.

---

## 🎯 الأهداف والمكتسبات الهندسية (Engineering Deliverables)

تطوير هذا النظام يضمن تحقيق فهم عميق لعدة مفاهيم برمجية متقدمة:
* **تحديات التوريث داخل القوالب (Templates):** فهم آلية تعامل المترجم مع نطاقات القوالب المفتوحة وتوظيف سياق `this` لحل قيود البحث البرمجي.
* **إعادة توجيه البيانات لفرض سلوك مخصص:** تحوير دالات القائمة المتصلة لخدمة منطق المكدس دون المساس ببنيتها الأساسية.
* **إعادة استخدام الكود (DRY Principle):** توسيع الأنظمة وتطوير هياكل برمجية معقدة دون تكرار الأسطر البرمجية عبر بناء هرمي سليم للكلاسات.

---

## 🚀 لغات وتقنيات مستخدمة

* **C++11 / C++17**
* **OOP Concepts (Inheritance, Polymorphism & Scope Resolution)**
* **C++ Templates & Generic Programming**
* **Template Bound Resolution & Contextual Pointers (`this->`)**

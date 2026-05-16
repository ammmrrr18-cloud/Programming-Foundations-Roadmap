# Custom Stack Implementation via Array-Based Queue Inheritance

This project represents an advanced engineering application to build a custom Stack data structure from scratch. It falls under the category of **Functional Systems**, designed by implementing class inheritance from an array-backed Queue system (`clsMyQueueArr`), showcasing structural optimization, context resolution using the `this` keyword, and LIFO (Last-In, First-Out) memory layout behavioral modification.

This advanced educational system was developed under the supervision and guidance of the esteemed engineer: **Mohammed Abu-Hadhoud** via [Programming Advices](https://programmingadvices.com/courses/enrolled/2001432).

---

## 📌 System Overview

The system is a Generic Template Class (`clsMyStackArr`) built in C++ that inherits directly from `clsMyQueueArr<T>`. By leveraging public inheritance, this layout adapts the contiguous memory engine of the array-backed queue to serve standard Stack features. A key architectural highlight of this codebase is the explicit usage of `this->` syntax, which cleanly bypasses dynamic template scope restrictions during compilation, providing high cross-platform stability.

---

## 🛠️ System Features

The system alters and re-routes the inherited dynamic array mechanisms to enforce strict stack constraints:

### 1. Core Stack Operations
* **Push Item:** Overrides the entry point behavior via the function `push(T item)`, utilizing `this->InsertAtFront(item)` to elegantly enforce the LIFO memory entry workflow at index 0.
* **Pop Item:** Inherits the capability to dequeue and shift elements sequentially from the array front via the inherited `pop()` method.

### 2. Element Access & Boundaries
* **Top Access:** Retrieves the current element sitting at the top of the stack via the function `Top()`, which maps directly to `this->front()`.
* **Bottom Access:** Retrieves the oldest element at the bottom boundary of the stack via the function `Bottom()`, mapping directly to `this->back()`.

---

## 💻 Code Architecture

Responsibilities within this **Functional System** demonstrate pure object-oriented hierarchies and strategic reuse over code duplication:

* **The Inheritance Layer & Structural Logic (`public clsMyQueueArr<T>`):** Conceptually, a Stack is highly identical to a Queue since they operate on top of the same structural parameters and container resources, with the definitive difference being that a Queue enforces **FIFO** (First-In, First-Out) while a Stack enforces **LIFO** (Last-In, First-Out). To elegantly resolve this, we utilized **Inheritance** instead of Composition. By inheriting the array-backed Queue infrastructure and performing a clean method **Override** on the `push(T item)` function, we completely eliminated code duplication. This architectural choice represents the optimal engineering solution for this layout.
* **The Explicit Context Pointer (`this->`):** Employing `this->` ensures strict template bound resolution during compile-time, acting as a clean code convention for dependent member access in generic programming.

---

## 🎯 Engineering Deliverables

Developing this system ensures a deep understanding of several advanced programming concepts:
* **Template Inheritance Scope:** Mastering why modern compilers require an explicit `this->` reference or explicit scope resolution to find dependent base class members in generic designs.
* **Algorithmic Adaptability:** Shifting contiguous array insertion parameters to transform a sequential buffer into a strict LIFO stack.
* **DRY Architecture (Don't Repeat Yourself):** Reusing utilities like capacity management, resizing, and counting metrics without repeating lines of code.

---

## 🚀 Technologies Used

* **C++11 / C++17**
* **OOP Concepts (Inheritance, Overriding, Hierarchy Architecture)**
* **C++ Templates & Generic Programming**
* **Template Bound Resolution & Contextual Pointers (`this->`)**

================================================================================

# بناء مكدس مخصص عن طريق توريث الطابور المبني على المصفوفة

هذا المشروع يمثل تطبيقاً هندسياً متقدماً لبناء هيكل بيانات المكدس (Stack) من الصفر بالاعتماد على المصفوفة المتسلسلة، وهو يندرج تحت تصنيف **Functional Systems** حيث تم تصميمه عن طريق تطبيق مبدأ التوريث من نظام الطابور المعتمد على المصفوفة الديناميكية (`clsMyQueueArr`) المبني سابقاً، لاستعراض الكفاءة البرمجية، والتحكم في نطاقات القوالب عبر الكلمة المفتاحية `this`.

تم تطوير هذا النظام التعليمي المتقدم تحت إشراف وتوجيه المهندس القدير: **محمد أبو هدهود** عبر [Programming Advices](https://programmingadvices.com/courses/enrolled/2001432).

---

## 📌 عن النظام (System Overview)

النظام عبارة عن فئة قالب عامة (`clsMyStackArr`) تم بناؤها بلغة C++، حيث ترث مباشرة من كلاس الطابور المصفوفي `clsMyQueueArr<T>`. من خلال توظيف علاقة التوريث (Inheritance)، يقوم هذا النظام بتحويل السلوك الخطي والمستمر للمصفوفة ليحاكي تماماً وظائف المكدس بآلية LIFO (الداخل أخيراً يخرج أولاً). وتكمن الميزة الهندسية البارزة هنا في الاستخدام الصريح للمؤشر `this->` لحل مشكلة التعرف على أسماء الدوال الموروثة داخل القوالب وتأمين استقرار الكود أثناء الترجمة.

---

## 🛠️ المميزات والوظائف البرمجية (System Features)

يقوم النظام بتكييف وتوجيه دالات المصفوفة الديناميكية الأساسية لفرض خصائص المكدس بأعلى كفاءة:

### 1. عمليات المكدس الأساسية (Core Stack Operations)
* **إضافة عنصر (Push):** تعديل سلوك الإدخال عبر الدالة `push(T item)` بالاعتماد الكامل على `this->InsertAtFront(item)` لحقن البيانات في مقدمة المصفوفة (الدليل 0) وفرض آلية الـ LIFO.
* **سحب عنصر (Pop):** يرث المكدس القدرة على إزالة العناصر تباعاً وبأمان من مقدمة المصفوفة عبر دالة `pop()` المستدعاة تلقائياً من الكلاس الأب.

### 2. عمليات الاستعلام والوصول (Element Access)
* **الوصول للأعلى (Top):** جلب قيمة العنصر الحالي الموجود على قمة المكدس عبر الدالة `Top()` والتي تقوم بالتوجيه الداخلي الذكي إلى `this->front()`.
* **الوصول للأسفل (Bottom):** جلب قيمة العنصر الأعمق الموجود في قاع المكدس عبر الدالة `Bottom()` والتوجيه المباشر إلى `this->back()`.

---

## 💻 هيكلية الكود البرمجي (Code Architecture)

تم تقسيم وتوزيع المسؤوليات داخل هذا الـ **Functional System** بالاعتماد على التوريث الصريح وفصل النطاقات:

* **طبقة التوريث والمنطق الهيكلي (`public clsMyQueueArr<T>`):** من الناحية الهندسة البرمجية، المكدس (Stack) يتشابه تماماً مع الطابور (Queue) في الخصائص والوظائف الداخلية للمصفوفة، ولكن الفارق الجوهري الوحيد يكمن في أن الطابور يطبق مبدأ **FIFO** (الداخل أولاً يخرج أولاً) بينما المكدس يطبق مبدأ **LIFO** (الداخل أخيراً يخرج أولاً). بناءً على ذلك، قمنا هنا بتطبيق مبدأ **التوريث (Inheritance)** بدلاً من الكومبيزشن (Composition)؛ حيث ورثنا بنية الطابور المصفوفي بالكامل وقمنا بعمل **Override** مخصص لدالة الإضافة `push(T item)` لتغير سلوك الإدخال، وذلك لتجنب تكرار الكود والدوال المشتركة (مثل الحجم، الطباعة، والتنظيف)، وهذا هو الحل الهندسي الأمثل والأكثر كفاءة لتصميم هذا النظام.
* **الربط الصريح للمؤشر السلوكي (`this->`):** يضمن استخدام `this->` توجيه الكومبيلر وفك الارتباط المبهم للمتغيرات والدوال الموروثة داخل القوالب الجينيريك (Dependent Names)، مما يرفع من جودة ونظافة التصميم الهيكلي.

---

## 🎯 الأهداف والمكتسبات الهندسية (Engineering Deliverables)

تطوير هذا النظام يضمن تحقيق فهم عميق لعدة مفاهيم برمجية متقدمة:
* **تحديات التوريث داخل القوالب (Templates):** فهم آلية تعامل المترجم مع نطاقات القوالب المفتوحة وتوظيف سياق `this` لحل قيود البحث البرمجي عن الدوال الموروثة.
* **إعادة توجيه حاويات المصفوفات لفرض سلوك مخصص:** تحوير دالات الإدخال الخاصة بالمصفوفة الديناميكية لخدمة منطق المكدس دون الحاجة لبناء الحاوية من الصفر.
* **إعادة استخدام الكود (DRY Principle):** استغلال الدوال الجاهزة مثل إدارة السعة، والتحقق من الخلو، والطباعة دون تكرار الأسطر البرمجية.

---

## 🚀 لغات وتقنيات مستخدمة

* **C++11 / C++17**
* **OOP Concepts (Inheritance, Overriding, Hierarchy Architecture)**
* **C++ Templates & Generic Programming**
* **Template Bound Resolution & Contextual Pointers (`this->`)**


# Custom Queue Implementation Using Dynamic Array

This project represents an engineering application to build an extended Queue data structure from scratch. It falls under the category of **Functional Systems**, designed as a wrapper layout that leverages a custom Dynamic Array container to implement advanced queue behaviors, optimizing contiguous memory reuse and index-based tracking.

This advanced educational system was developed under the supervision and guidance of the esteemed engineer: **Mohammed Abu-Hadhoud** via [Programming Advices](https://programmingadvices.com/courses/enrolled/2001432).

---

## 📌 System Overview

The system is a Generic Template Class (`clsMyQueueArr`) built in C++ that expands the capabilities of a standard Queue. By utilizing a custom Dynamic Array (`_MyList`) as its core engine, this system bridges the gap between contiguous sequential memory allocations and FIFO (First-In, First-Out) operations. This architecture allows developers to perform standard queue transactions while maintaining absolute flexibility to update, reverse, and dynamically inject items at specified boundaries.

---

## 🛠️ System Features

The system offers a comprehensive suite of operations designed to manipulate and manage data elements inside the array-backed queue:

### 1. Core FIFO operations
* **Push Item:** Enqueues a new element to the back of the queue via the function `push(T Item)`, leveraging the dynamic array's tail insertion capability.
* **Pop Item:** Dequeues and safely removes the oldest element from the front of the queue via the function `pop()`.
* **Clear Queue:** Completely empties the container and reallocates a zero-size buffer via the function `Clear()`.

### 2. Boundary Extensions & Custom Insertions
* **Insert at Front:** Injects a new element directly at index 0 via the function `InsertAtFront(T item)`.
* **Insert at Back:** Injects a new element at the current tail boundary via the function `InsertAtBack(T item)`.
* **Insert After Index:** Shifts downstream data to inject an item after a specified reference position via the function `InsertAfter(int index, T item)`.

### 3. Element Access & Context Control
* **Front Access:** Retrieves the value of the leading element via the function `front()`.
* **Back Access:** Retrieves the value of the closing element via the function `back()`.
* **Access Value by Index:** Fetches any item anywhere inside the queue based on its absolute index via the function `GetItem(int index)`.
* **Update and Modify:** Updates the underlying array buffer at a precise index via the function `UpdateItem(int index, T item)`.
* **Reverse Queue:** Flipped the layout sequence entirely in-memory via the function `Reverse()`.
* **Size Verification & Utilities:** Provides quick checks via `Size()` and structural rendering via the function `Print()`.

---

## 💻 Code Architecture

Responsibilities within this **Functional System** demonstrate robust separation of layouts via structural reuse:

* **The Composition Pattern (`_MyList`):** Here, we applied the **Composition** principle by embedding an instance of `clsDynamicArray<T>` as a protected data member. This completely abstracts away low-level memory reallocations, copying cycles, and `delete[]` tasks, utilizing the dynamic array's continuous memory buffer as a reliable infrastructure.
* **Public Boundary Wrappers:** Exposes clean high-level operations that enforce proper queue business logic while validating internal indexes against the array's boundaries.

---

## 🎯 Engineering Deliverables

Developing this system ensures a deep understanding of several advanced programming concepts:
* **Array-Based vs List-Based Stacks/Queues:** Analyzing how contiguous memory buffers behave during head/tail insertions compared to node link connections.
* **The Composition Design Principle:** Mastering how to construct high-level structural patterns by wrapping existing data containers cleanly.
* **Data Mutation Overhead:** Understanding the architectural weight of shifting elements during array re-allocations.

---

## 🚀 Technologies Used

* **C++11 / C++17**
* **OOP Concepts (Encapsulation, Protected Data Composition)**
* **C++ Templates & Generic Programming**
* **Code Reuse & Layered Architecture Principles**

================================================================================

# بناء طابور مخصص باستعمال المصفوفة الديناميكية

هذا المشروع يمثل تطبيقاً هندسياً متكاملاً لبناء هيكل بيانات الطابور المطور (Queue) من الصفر، وهو يندرج تحت تصنيف **Functional Systems** حيث تم تصميمه كغلاف برمجى يعتمد على كلاس المصفوفة الديناميكية المبني مسبقاً، لتوفير نظام طابور يعتمد على كفاءة تخزين الذاكرة المتسلسلة والمستمرة.

تم تطوير هذا النظام التعليمي المتقدم تحت إشراف وتوجيه المهندس القدير: **محمد أبو هدهود** عبر [Programming Advices](https://programmingadvices.com/courses/enrolled/2001432).

---

## 📌 عن النظام (System Overview)

النظام عبارة عن فئة قالب عامة (`clsMyQueueArr`) تم بناؤها بلغة C++، لتوسيع وتحسين قدرات الطابور القياسي. من خلال الاعتماد على المصفوفة الديناميكية المخصصة (`_MyList`) كمحرك أساسي لتخزين البيانات، يجمع هذا النظام بين كفاءة الوصول المباشر للمصفوفات المتسلسلة وبين منطق عمليات FIFO (الداخل أولاً يخرج أولاً)، مما يعطي المطور صلاحيات مخصصة لتحديث، عكس، وحقن العناصر في أماكن محددة داخل الطابور بأمان.

---

## 🛠️ المميزات والوظائف البرمجية (System Features)

يحتوي النظام على حزمة متكاملة من العمليات البرمجية الموزعة كالتالي لخدمة عناصر الطابور:

### 1. عمليات الطابور الأساسية (Core FIFO Operations)
* **إضافة عنصر (Push):** إدراج عنصر جديد في نهاية الطابور عبر الدالة `push(T Item)` بالاعتماد على ميزة الإضافة الخلفية للمصفوفة.
* **سحب عنصر (Pop):** إزالة العنصر الأول والأقدم من مقدمة الطابور وإعادة هيكلة الحاوية عبر الدالة `pop()`.
* **تنظيف الطابور كاملاً:** تصفير الحجم ومسح كافة المحتويات المحجوزة بأمان عبر الدالة `Clear()`.

### 2. عمليات الإدراج والتوسعة المخصصة
* **الإضافة في المقدمة:** حقن عنصر جديد مباشرة في الدليل الرقمي 0 عبر الدالة `InsertAtFront(T item)`.
* **الإضافة في المؤخرة:** إدراج عنصر جديد في نهاية الحدود الحالية للمصفوفة عبر الدالة `InsertAtBack(T item)`.
* **الإدراج المخصص بعد دليل:** إزاحة البيانات الخلفية وحقن عنصر جديد بعد رقم دليل مرجعي معين عبر الدالة `InsertAfter(int index, T item)`.

### 3. عمليات الاستعلام والتحكم والوصول
* **الوصول للمقدمة:** جلب قيمة أول عنصر في الطابور عبر الدالة `front()`.
* **الوصول للمؤخرة:** جلب قيمة آخر عنصر موجود في الطابور عبر الدالة `back()`.
* **الوصول للقيمة بالدليل:** جلب قيمة أي عنصر في أي موضع داخل الطابور بناءً على دليله المباشر عبر الدالة `GetItem(int index)`.
* **التحديث والتعديل:** تعديل قيمة عنصر موجود بالفعل في موقع محدد داخل مصفوفة الطابور عبر الدالة `UpdateItem(int index, T item)`.
* **عكس الطابور:** إعادة ترتيب المصفوفة الداخلية وعكس اتجاه البيانات بالكامل في الذاكرة عبر الدالة `Reverse()`.
* **مراقبة وفحص الحالة:** دوال فورية لبيان حجم الحاوية عبر `Size()` وطباعة محتوياتها المتسلسلة عبر الدالة `Print()`.

---

## 💻 هيكلية الكود البرمجي (Code Architecture)

تم تقسيم وتوزيع المسؤوليات داخل هذا الـ **Functional System** من خلال مبدأ إعادة استخدام الحاويات الهيكلية:

* **مخزن البيانات المعتمد على مبدأ الكومبيزشن (`_MyList`):** هنا قمنا بتطبيق مبدأ التركيب (**Composition**) عن طريق تضمين كائن من المصفوفة الديناميكية المخصصة `clsDynamicArray<T>` كعنصر داخلي محمي (Protected). هذا التخطيط يحجب تماماً عمليات حجز الذاكرة منخفضة المستوى، عمليات النسخ، والحذف بمعامل `delete[]`، مستفيداً من كفاءة المصفوفة المتصلة كبنية تحتية موثوقة.
* **أغلفة الواجهة العامة (Public Interface):** توفر للمطورين دالات عالية المستوى تضمن سلامة المنطق البرمجي للطابور مع التحقق من صحة المؤشرات والأدلة الممررة قبل تنفيذ دالات المصفوفة الحساسة.

---

## 🎯 الأهداف والمكتسبات الهندسية (Engineering Deliverables)

تطوير هذا النظام يضمن تحقيق فهم عميق لعدة مفاهيم برمجية متقدمة:
* **المقارنة الهندسية للحاويات (Array-Based vs List-Based):** تحليل الاختلاف السلوكي في الذاكرة ومعدل استهلاك المعالج بين الطوابير المبنية على المصفوفات المتسلسلة وتلك المبنية على القوائم المتصلة.
* **مبدأ التركيب (Composition Design Principle):** إتقان بناء أنواع بيانات مجردة وعالية المستوى من خلال تغليف وتطويع حاويات بيانات أخرى مجهزة مسبقاً.
* **تكلفة نقل البيانات (Mutation Overhead):** فهم الأثر البرمجي لعمليات الترحيل والإزاحة للعناصر داخل الذاكرة المستمرة أثناء الإدخال والحذف.

---

## 🚀 لغات وتقنيات مستخدمة

* **C++11 / C++17**
* **OOP Concepts (Encapsulation, Protected Data Composition)**
* **C++ Templates & Generic Programming**
* **Code Reuse & Layered Architecture Principles**

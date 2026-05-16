
# Custom Dynamic Array Generic Implementation

This project represents an advanced engineering application to build a custom Dynamic Array (Vector-like layout) from scratch. It falls under the category of **Functional Systems**, designed as a generic container that provides absolute control over continuous dynamic memory allocation, precise resizing mechanics, and index-based element manipulation.

This advanced educational system was developed under the supervision and guidance of the esteemed engineer: **Mohammed Abu-Hadhoud** via [Programming Advices](https://programmingadvices.com/courses/enrolled/2001432).

---

## 📌 System Overview

The system is a Generic Template Class (`clsDynamicArray`) built in C++ that manages raw arrays dynamically allocated on the Heap. Unlike static arrays, this system automates runtime expansion and contraction of memory, abstracting away pointer arithmetic and structural shifts during element injection or removal, while providing safe boundary checking to ensure memory integrity.

---

## 🛠️ System Features

The system offers a wide array of memory operations, categorized as follows:

### 1. Element Insertion & Injection
* **Insert at Specific Index:** Injects an element at any valid index while dynamically shifting subsequent items via the function `InsertAt(int index, T item)`.
* **Insert at Beginning:** Places an element at the very front of the array via the function `InsertAtBeginning(T item)`.
* **Insert at End:** Appends a new element to the tail of the array via the function `InsertAtEnd(T item)`.
* **Insert Before/After Index:** Contextual insertion routines based on reference index positioning via the functions `InsertBefore(int index, T item)` and `InsertAfter(int index, T item)`.

### 2. Element Deletion & Cleanup
* **Delete at Specific Index:** Removes an item from a given index, automatically shifting memory back to close the gap via the function `DeleteItemAt(int index)`.
* **Delete First/Last Item:** Targeted removals from the array boundaries via the functions `DeleteFirstItem()` and `DeleteLastItem()`.
* **Delete by Value:** Searches for an item by value and removes its first occurrence via the function `DeleteItem(T value)`.
* **Clear Array:** Resets the array size to zero and wipes out the allocated blocks safely via the function `Clear()`.

### 3. Array Resizing, Search, & Access
* **Manual Resize:** Explicitly scales the array's capacity up or down while preserving current data via the function `Resize(int NewSize)`.
* **Set and Get Items:** Safe access and modification wrappers featuring range validation via the functions `SetItem(int index, T item)` and `GetItem(int index)`.
* **Linear Search:** Finds the positional index of a targeted value via the function `Find(T value)`.
* **Reverse Array:** Flips the entire array sequence seamlessly in-memory via the function `Reverse()`.
* **Size Monitoring & Printing:** Immediate verification routines via the functions `Size()`, `IsEmpty()`, and sequential output rendering via `PrintList()`.

---

## 💻 Code Architecture

Responsibilities within this **Functional System** demonstrate explicit low-level memory handling and pointer swapping:

* **Dynamic Heap Management (`OriginalArray` & `_TempArray`):** The internal core relies on managing a pointer (`T* OriginalArray`). During mutations (like resizing or deletion), a temporary pointer (`_TempArray`) allocates the new required space on the Heap, copies the current layout, and then the system carefully deletes the old allocated buffer using the `delete[]` operator to eliminate memory leaks.
* **Encapsulated Scope Protection:** Crucial structural parameters like `_Size` are protected (`protected`), allowing for clean future framework inheritance while maintaining control boundary safety.

---

## 🎯 Engineering Deliverables

Developing this system ensures a deep understanding of several advanced programming concepts:
* **Manual Heap Allocations:** Gaining a profound command over the mechanics of `new[]` and `delete[]` and understanding why pointers must be set to `NULL` post-deallocation.
* **Memory Shifting & Copying:** Implementing shifting loops during item insertion or deletion, optimizing the data movement cycle.
* **Pointer Arithmetic and References:** Applying standard pointer redirection safely within a template environment.

---

## 🚀 Technologies Used

* **C++11 / C++17**
* **OOP Concepts (Encapsulation, Dynamic Scope Management)**
* **C++ Templates & Generic Programming**
* **Low-Level Memory Management (Heap Allocation, Pointer Swapping)**

================================================================================

# مصفوفة ديناميكية مخصصة متكاملة القوالب

هذا المشروع يمثل تطبيقاً هندسياً متكاملاً لبناء مصفوفة ديناميكية (Dynamic Array) تحاكي خصائص الـ Vector من الصفر. وهو يندرج تحت تصنيف **Functional Systems**، حيث تم تصميمه كحاوية عامة توفر تحكماً مطلقاً في حجز الذاكرة العشوائية المستمرة وتغيير حجمها برمجياً مع إدارة عمليات الإدراج والحذف بكفاءة.

تم تطوير هذا النظام التعليمي المتقدم تحت إشراف وتوجيه المهندس القدير: **محمد أبو هدهود** عبر [Programming Advices](https://programmingadvices.com/courses/enrolled/2001432).

---

## 📌 عن النظام (System Overview)

النظام عبارة عن فئة قالب عامة (`clsDynamicArray`) تم بناؤها بلغة C++ لإدارة المصفوفات الخام المحجوزة ديناميكياً داخل الذاكرة (Heap). على عكس المصفوفات الاستاتيكية الثابتة، يقوم هذا النظام بآلية التوسع والانكماش التلقائي لحجم المصفوفة أثناء التشغيل، مما يعفي المطور من تعقيدات عمليات ترحيل المؤشرات وإعادة توزيع مساحات العناصر مع فرض قيود أمان صارمة لمنع تجاوز حدود الحجز في الذاكرة.

---

## 🛠️ المميزات والوظائف البرمجية (System Features)

يحتوي النظام على حزمة شاملة من العمليات البرمجية الموزعة كالتالي:

### 1. عمليات الإدراج وإضافة العناصر
* **الإدراج في دليل محدد:** إضافة عنصر جديد في أي دليل (Index) صالح مع إزاحة العناصر التالية تلقائياً عبر الدالة `InsertAt(int index, T item)`.
* **الإضافة في البداية:** وضع العنصر مباشرة في أول القائمة عبر الدالة `InsertAtBeginning(T item)`.
* **الإضافة في النهاية:** ملء مصفوفة جديدة وإلحاق العنصر في الذيل عبر الدالة `InsertAtEnd(T item)`.
* **الإدراج قبل/بعد دليل معين:** دوال ذكية تقوم بالتحويل التلقائي لتحديد موضع العنصر الجديد نسبة لعنصر مرجعي عبر الدالتين `InsertBefore(int index, T item)` و `InsertAfter(int index, T item)`.

### 2. عمليات الحذف والتنظيف
* **الحذف من دليل محدد:** إزالة العنصر من موقعه وإعادة ترحيل البيانات الخلفية لسد الفراغ عبر الدالة `DeleteItemAt(int index)`.
* **حذف العنصر الأول/الأخير:** عمليات استهداف مباشرة لأطراف المصفوفة الحالية عبر الدالتين `DeleteFirstItem()` و `DeleteLastItem()`.
* **الحذف بالقيمة:** البحث عن قيمة معينة وحذف أول ظهور لها بأمان عبر الدالة `DeleteItem(T value)`.
* **تفريغ المصفوفة بالكامل:** تصفير حجم المصفوفة ومسح المساحة المحجوزة نهائياً من الذاكرة عبر الدالة `Clear()`.

### 3. عمليات الحجم، البحث، والتحكم
* **تعديل الحجم يدوياً:** إعادة جدولة مساحة المصفوفة بالزيادة أو النقصان مع الحفاظ على البيانات القديمة عبر الدالة `Resize(int NewSize)`.
* **تعديل وجلب العناصر:** دوال وصول آمنة مدمج بها فحص الحدود عبر الدالتين `SetItem(int index, T item)` و `GetItem(int index)`.
* **البحث الخطي:** استخراج الدليل الرقمي لموضع قيمة معينة داخل المصفوفة عبر الدالة `Find(T value)`.
* **عكس المصفوفة:** إعادة ترتيب عناصر المصفوفة وعكس اتجاهها بالكامل في الذاكرة عبر الدالة `Reverse()`.
* **مراقبة وفحص الحالة:** دوال فورية لبيان حجم الحاوية عبر `Size()`، وفحص خلوها عبر `IsEmpty()`، وطباعتها عبر `PrintList()`.

---

## 💻 هيكلية الكود البرمجي (Code Architecture)

تم تقسيم المسؤوليات داخل هذا الـ **Functional System** بالاعتماد على التلاعب المباشر بالمؤشرات وتبديل العناوين في الذاكرة:

* **إدارة الذاكرة الديناميكية (`OriginalArray` و `_TempArray`):** يرتكز الكيان الداخلي على مؤشر أساسي (`T* OriginalArray`). عند حدوث أي تعديل هيكلي (مثل تغيير الحجم أو الحذف)، يتم تخصيص مؤشر مؤقت (`_TempArray`) لحجز مساحة جديدة على الـ Heap، ومن ثم نسخ البيانات الحالية إليه، وبعد ذلك يقوم النظام بحذف النطاق القديم عبر المعامل `delete[]` لمنع حدوث أي تسريب للذاكرة (Memory Leaks).
* **حماية النطاق البرمجي:** تم إبقاء المتغيرات الهيكلية مثل `_Size` في النطاق المحمي (`protected`) لضمان إمكانية توريث الكلاس وتوسيع وظائفه مستقبلاً بأمان.

---

## 🎯 الأهداف والمكتسبات الهندسية (Engineering Deliverables)

تطوير هذا النظام يضمن تحقيق فهم عميق لعدة مفاهيم برمجية متقدمة:
* **التحكم اليدوي في الذاكرة (Heap Allocation):** إتقان التعامل الصارم مع المعاملين `new[]` و `delete[]` وفهم حتمية تصفير المؤشرات بـ `NULL`.
* **منطق إزاحة الذاكرة (Memory Shifting):** بناء حلقات تكرارية قادرة على إعادة جدولة مواقع البيانات في الذاكرة بدقة أثناء عمليات الحذف والإدخال.
* **البرمجة العامة والمرونة (Templates):** فصل منطق الحاوية الفيزيائي عن طبيعة البيانات بداخلها لتقديم أقصى درجات قابلية إعادة الاستخدام.

---

## 🚀 لغات وتقنيات مستخدمة

* **C++11 / C++17**
* **OOP Concepts (Encapsulation, Dynamic Scope Management)**
* **C++ Templates & Generic Programming**
* **Low-Level Memory Management (Heap Allocation, Pointer Swapping)**

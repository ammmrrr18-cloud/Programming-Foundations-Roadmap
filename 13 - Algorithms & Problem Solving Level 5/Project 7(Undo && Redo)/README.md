
# Smart String Management System with Advanced Undo and Redo Architecture

This project represents a sophisticated engineering application to build a custom smart String management class from scratch. It falls under the category of **Functional Systems**, designed to manage textual data dynamically while tracking operational state history through dual-stack tracking mechanics, allowing infinite history rollback and forward re-execution capabilities.

This advanced educational system was developed under the supervision and guidance of the esteemed engineer: **Mohammed Abu-Hadhoud** via [Programming Advices](https://programmingadvices.com/courses/enrolled/2001432).

---

## 📌 System Overview

The system is a specialized Class (`clsMyString`) built in C++ that encapsulates standard string operations with an automated transactional rollback mechanism. By implementing two internal container components (`_Undo` and `_Redo` stacks), the system takes full memory snapshots of the string value prior to any structural modifications. This layout ensures efficient historical navigation while abstracting property accessor lookups via Microsoft-specific compiler properties.

---

## 🛠️ System Features

The system offers a refined suite of functions designed to control string mutation transactions and manage timeline historical benchmarks:

### 1. Data Modification & Encapsulated Access
* **Set Value Transaction:** Updates the main string text while automatically pushing the old state into the rollback history container via the function `Set(string value)`.
* **Get Current Value:** Safely retrieves the active string state currently residing in active memory via the function `Get()`.
* **Compiler-Level Property Layout:** Implements modern code ergonomics using `__declspec(property(get = Get, put = Set)) string Value;` allowing developers to access and modify properties seamlessly without writing direct method invocation syntax.

### 2. Transactional History Control
* **Undo Operation:** Rolls back the active string value to its previous chronological benchmark via the function `Undo()`. It safely buffers the cancelled value into the forward track container to support recovery.
* **Redo Operation:** Re-executes a previously undone transaction, restoring the forward-cached state cleanly via the function `Redo()`, while buffering the old state back into the rollback tracking sequence.

---

## 💻 Code Architecture

Responsibilities within this **Functional System** demonstrate proper state machine isolation and composition design choices:

* **Dual-Stack History Trackers (`_Undo` and `_Redo`):** The core engine relies on standard template stacks (`stack<string>`). The `_Undo` stack preserves historical checkpoints in a LIFO manner, ensuring that the latest modification is always the first to be restored. The `_Redo` stack holds subsequent forward actions, clearing out or filling up dynamically based on programmatic navigation choices.
* **Property Wrappers and Data Safety:** Strict segregation of the underlying `_value` member ensures that no accidental or unrecorded modifications can disrupt the transactional history tracking.

---

## 🎯 Engineering Deliverables

Developing this system ensures a deep understanding of several advanced programming concepts:
* **The Command and Memento Design Concepts:** Utilizing standard containers to store snapshots of data objects for precise state recovery workflows.
* **Compiler-Specific Optimizations:** Mastering native compiler metadata tags like `__declspec` to expose properties in C++ that match modern programming language workflows.
* **Dual-Stack Interactivity:** Mapping complex data flow transitions where two independent containers swap elements to manage chronological navigation.

---

## 🚀 Technologies Used

* **C++11 / C++17**
* **OOP Concepts (Encapsulation, State Machine Formatting)**
* **C++ Standard Template Library (`std::stack`)**
* **Advanced Compiler Extensions (`__declspec(property)`)**

================================================================================

# نظام إدارة النصوص الذكي مع بنية التراجع والإعادة المتقدمة

هذا المشروع يمثل تطبيقاً هندسياً متميزاً لبناء كلاس نصوص ذكي ومخصص من الصفر. وهو يندرج تحت تصنيف **Functional Systems**، حيث تم تصميمه لإدارة النصوص برمجياً مع تتبع تاريخ العمليات عبر آلية المكدس المزدوج (Dual-Stack)، مما يتيح ميزات التراجع (Undo) والإعادة (Redo) اللانهائية لعمليات تعديل البيانات.

تم تطوير هذا النظام التعليمي المتقدم تحت إشراف وتوجيه المهندس القدير: **محمد أبو هدهود** عبر [Programming Advices](https://programmingadvices.com/courses/enrolled/2001432).

---

## 📌 عن النظام (System Overview)

النظام عبارة عن كلاس مخصص (`clsMyString`) تم بناؤه بلغة C++ لتغليف النصوص وحمايتها برمجياً مع دمج نظام معاملات آمن لحفظ الحالات التاريخية للنص. من خلال دمج حاويتين داخليتين (`_Undo` و `_Redo` Stacks)، يقوم النظام بأخذ لقطات كاملة من الذاكرة (Snapshots) لقيمة النص قبل أي تعديل، مما يضمن للمطور القدرة على التنقل عبر خط الزمن للعمليات البرمجية بسلاسة مع تيسير عمليات الوصول عبر خصائص المترجم المتقدمة.

---

## 🛠️ المميزات والوظائف البرمجية (System Features)

يقدم النظام حزمة وظائف ذكية للتحكم في مدخلات النصوص وتوجيه الحالات الزمنية لها كالتالي:

### 1. تعديل البيانات والوصول المغلف
* **تعديل النص (Set):** تحديث القيمة الأساسية للنص مع ترحيل وتأمين الحالة القديمة تلقائياً إلى مكدس التراجع عبر الدالة `Set(string value)`.
* **جلب النص (Get):** استدعاء النص الفعال والنشط حالياً في الذاكرة بأمان عبر الدالة `Get()`.
* **تطبيق الخصائص على مستوى المترجم:** صياغة برمجية حديثة باستخدام الأمر `__declspec(property(get = Get, put = Set)) string Value;` تتيح للمطورين التعامل مع الدالات كمتغيرات مباشرة، مما يرفع من جودة ونظافة الكود.

### 2. التحكم في المعاملات والتاريخ البرمجي
* **عملية التراجع (Undo):** عكس العملية الحالية وإعادة النص إلى الحالة السابقة مباشرة عبر الدالة `Undo()`، مع حفظ القيمة الملغاة في مكدس الإعادة لإتاحة استرجاعها.
* **عملية الإعادة (Redo):** استعادة الخطوة التي تم التراجع عنها وإعادة تطبيقها برمجياً عبر الدالة `Redo()`، مع إعادة ترحيل الحالة الحالية إلى مكدس التراجع لضمان التوازن الهيكلي.

---

## 💻 هيكلية الكود البرمجي (Code Architecture)

تم تقسيم وتوزيع المسؤوليات داخل هذا الـ **Functional System** بالاعتماد على كبسلة الحالة وتكامل مبدأ الـ Composition:

* **المكدس المزدوج لتتبع التاريخ (`_Undo` و `_Redo`):** يعتمد المحرك الداخلي على حاويات المكدس القياسية لـ C++ (`stack<string>`). يعمل مكدس `_Undo` على حفظ نقاط برمجية مرتبة بآلية LIFO لضمان أن آخر تعديل هو أول ما يتم استرجاعه، بينما يعمل مكدس `_Redo` كحاوية مؤقتة للحركات المستقبلية الملغاة لتأمين التنقل العكسي.
* **حماية وتغليف المتغيرات:** عزل المتغير الأساسي `_value` تماماً يضمن عدم حدوث أي تغيير عشوائي للنص خارج نطاق المعاملات المؤرشفة برمجياً.

---

## 🎯 الأهداف والمكتسبات الهندسية (Engineering Deliverables)

تطوير هذا النظام يضمن تحقيق فهم عميق لعدة مفاهيم برمجية متقدمة:
* **تطبيقات أنماط التصميم (Memento Design Pattern):** فهم كيفية استغلال حاويات البيانات لتسجيل وتوثيق حالات الكائنات لإنشاء أنظمة قادرة على استعادة البيانات عند الأخطاء.
* **إضافات المترجم المتقدمة (Compiler Extensions):** التعامل مع الكلمات المفتاحية الأصلية للمترجم مثل `__declspec` لإنشاء خصائص ذكية تحاكي اللغات البرمجية الحديثة.
* **التفاعل البرمجي التبادلي:** إتقان آلية نقل وتداول البيانات بين حاويتين مستقلتين لإدارة الحالات الزمنية للمتغيرات.

---

## 🚀 لغات وتقنيات مستخدمة

* **C++11 / C++17**
* **OOP Concepts (Encapsulation, State Machine Formatting)**
* **C++ Standard Template Library (`std::stack`)**
* **Advanced Compiler Extensions (`__declspec(property)`)**

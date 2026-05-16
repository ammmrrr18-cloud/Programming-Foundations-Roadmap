# Algorithms & Problem Solving – Level 5 (Data Structures & Core Engineering)

Welcome to the ultimate milestone repository for **Level 13** of the programming journey. This repository marks the successful completion of **Part One of the Programming Roadmap**. 

This course is entirely practice and project-driven, designed to reinforce theoretical concepts from *Data Structures – Level 1* through incremental expansion, testing endurance, discipline, and real-world software maintenance scenarios. Every system within this repository was developed under the professional supervision and academic guidance of the esteemed engineer: **Mohammed Abu-Hadhoud** via the [Programming Advices](https://programmingadvices.com/) platform.

---

## 📌 Architectural Philosophy & Course Summary

The primary focus of this course is to transition from a theoretical understanding of data containers to applying them naturally inside complex systems that handle changing requirements without losing structural integrity. 

This repository is organized into distinct **Functional Systems**. Each project represents a gradual increase in complexity, responsibility, and scope, simulating true software engineering workflows rather than isolated exercises.

---

## 💻 Repository Roadmap & Functional Systems Links

### 📂 [Project 1: Core Doubly Linked List System](https://github.com/ammmrrr18-cloud/Programming-Foundations-Roadmap/blob/main/13%20-%20Algorithms%20%26%20Problem%20Solving%20Level%205/Project%201/Extension%208(%20%20%20MydblLinkedList.InsertAfter%20(int%20index%2C%20T%20Value%20)%20%20)/Teacher-Soution/clsDblLinkedList.h)
* **Concept:** Building a generic double-link node architecture where elements maintain synchronous bidirectional awareness.
* **Key Architecture:** Direct raw pointer manipulation (`Next` and `Prev`), dynamic node synchronization, and manual memory boundary management.

### 📂 [Project 2: Custom Queue via List Composition](https://github.com/ammmrrr18-cloud/Programming-Foundations-Roadmap/blob/main/13%20-%20Algorithms%20%26%20Problem%20Solving%20Level%205/Project%202/Extension%201%20to%207%20(%20GetItem(int%20index)%20%2C%20%20Reverse()%20%20%2C%20%20UpdateItem()%20%2C%20InsertAfter(%20)%20%2CInsertAtFront()%20%20%2C%20%20InsertAtBack()%20%20%2C%20Clear()%20%20)/Teacher-Solution/clsMyQueue.h)
* **Concept:** Designing a standard FIFO (First-In, First-Out) queue wrapper using an underlying list.
* **Key Architecture:** **Composition Design Pattern**. By embedding the Doubly Linked List as a protected member, the system exposes a clean public interface while safely encapsulating pointer complexities away from the developer.

### 📂 [Project 3: Custom Stack via Queue Inheritance](https://github.com/ammmrrr18-cloud/Programming-Foundations-Roadmap/blob/main/13%20-%20Algorithms%20%26%20Problem%20Solving%20Level%205/Project%203/Teacher-Solution/clsMyStack.h)
* **Concept:** Re-purposing the existing linear queue framework to behave as a strict LIFO (Last-In, First-Out) stack container.
* **Key Architecture:** **Class Inheritance & Method Overriding**. Since both structures share almost identical parameters, inheriting the queue layout and overriding the `push` function to insert elements at the front avoided code duplication, providing the optimal engineering layout. It explicitly utilizes the `this->` context pointer to resolve generic template dependencies cleanly.

### 📂 [Project 4: Custom Dynamic Array Generic Engine](https://github.com/ammmrrr18-cloud/Programming-Foundations-Roadmap/blob/main/13%20-%20Algorithms%20%26%20Problem%20Solving%20Level%205/Project%204/%20%20Extension%2011%20to%2014/My-Solution/clsDynamicArray.h)
* **Concept:** Building a fully customizable, vector-like dynamic array capable of runtime memory expansion and contraction.
* **Key Architecture:** Continuous Heap allocation management utilizing `new[]` and `delete[]` keywords, safe index-based boundary checks, and memory-shifting loops during runtime insertions and deletions.

### 📂 [Project 5: Custom Queue Using Dynamic Array Engine](https://github.com/ammmrrr18-cloud/Programming-Foundations-Roadmap/blob/main/13%20-%20Algorithms%20%26%20Problem%20Solving%20Level%205/Project%205/clsMyQueueArr.h)
* **Concept:** Bridging the gap between contiguous memory allocation schemas and standard FIFO queuing pipelines.
* **Key Architecture:** **Composition Pattern**. Wrapping the custom Dynamic Array component internally to abstract away low-level buffer reallocation overhead while providing index-validated head and tail operations.

### 📂 [Project 6: Custom Stack via Array-Based Queue Inheritance](https://github.com/ammmrrr18-cloud/Programming-Foundations-Roadmap/blob/main/13%20-%20Algorithms%20%26%20Problem%20Solving%20Level%205/Project%206/clsMyStackArr.h)
* **Concept:** Adapting the contiguous array-backed queue architecture into a strict LIFO stack.
* **Key Architecture:** **Inheritance & Polymorphism**. Reusing the entire array-backed queue core and overriding method behaviors explicitly with the `this->` pointer, ensuring zero duplicate operations for identical capacity metrics.

### 📂 [Project 7: Transactional String State Tracker with Undo/Redo](https://github.com/ammmrrr18-cloud/Programming-Foundations-Roadmap/blob/main/13%20-%20Algorithms%20%26%20Problem%20Solving%20Level%205/Project%207(Undo%20%26%26%20Redo)/clsMyString.h)
* **Concept:** Constructing an advanced text management class featuring unlimited timeline rollback and forward history reconstruction.
* **Key Architecture:** **Dual-Stack History Tracking Framework**. Leveraging mutual interaction between tracking components to swap state snapshots dynamically, wrapped nicely inside clean property definitions.

### 📂 [Project 8: Bank Queue Line Simulation System](https://github.com/ammmrrr18-cloud/Programming-Foundations-Roadmap/blob/main/13%20-%20Algorithms%20%26%20Problem%20Solving%20Level%205/Project%208/Teacher-Solution/clsQueueLine.h)
* **Concept:** A real-world dispatching simulation engine for customer flows and waiting time metrics.
* **Key Architecture:** **Nested Class Design (`clsTicket`)** for atomic isolation, combined with non-destructive container traversal strategies utilizing temporary replica scopes to render multi-directional lines safely.

---

## 🎯 Core Learning Outcomes

Completing this advanced level provides a profound command over the following software engineering paradigms:
1. **System Extension Safety:** Learning how to extend existing architectures cleanly without breaking backward compatibility.
2. **Dynamic Scope Resolution:** Understanding template dependent name resolutions and the crucial deployment of the `this` contextual pointer.
3. **Incremental Requirement Management:** Handling increasing feature requests while maintaining absolute control over the code logic.

---

## 🔮 Next Step: Transitioning to Part Two

Completing this course officially validates foundational strength for Part One of the journey. The next stage marks the beginning of **Part Two**, focusing on becoming a strong backend engineer through structural ecosystem shifting:
* **C# Programming Language:** Transitioning to a high-level, production-grade professional language.
* **Advanced Database Mastery:** Completing 4 deep, practical database tracks.
* **Ecosystem Shift:** Moving beyond isolated local memory configurations to deploy, build, and sell robust backend systems that adapt freely across web, desktop, and enterprise specialization fields.

================================================================================

# خوارزميات وحل المشكلات – المستوى الخامس (هندسة تراكيب البيانات)

مرحباً بك في المستودع البرمجي الختامي والربط الشامل الخاص بـ **المستوى الثالث عشر (Level 13)** من الرحلة البرمجية. يمثل هذا المستودع نقطة النهاية والاعتماد الرسمي لإتمام **الجزء الأول من خارطة طريق البرمجة (Part One of the Roadmap)**.

هذا الكورس تطبيقي وعملي بالكامل، وهو مصمم لترسيخ المفاهيم النظرية التي تم تحصيلها في *تراكيب البيانات - المستوى الأول* من خلال مشاريع متكاملة قابلة للتوسيع التدريجي، ومصممة لاختبار المرونة والانضباط، ومحاكاة بيئات العمل الحقيقية لتعديل الأنظمة وتطويرها. تم تطوير كافة الأنظمة داخل هذا المستودع تحت الإشراف البرمجي والتوجيه الأكاديمي للمهندس القدير: **محمد أبو هدهود** عبر منصة [Programming Advices](https://programmingadvices.com/).

---

## 📌 الفلسفة الهندسية وملخص المستوى

الهدف الأساسي من هذا المستوى هو التمكن من توظيف واستخدام تراكيب البيانات بشكل طبيعي وتلقائي داخل الأنظمة البرمجية المعقدة، والقدرة على توسيع خصائصها البرمجية بأمان لمواجهة المتطلبات المتغيرة دون المساس باستقرار هيكل الكود الأساسي.

تم تنظيم هذا المستودع على شكل أنظمة وظيفية متكاملة تندرج تحت تصنيف **Functional Systems**، حيث يتزايد حجم ونطاق المسؤولية والتعقيد الهندسي مع كل مشروع بشكل تدريجي لمحاكاة دورة التطوير الفعلية للبرمجيات وليس مجرد تمارين معزولة.

---

## 💻 خريطة طريق المستودع وروابط الأنظمة البرمجية

### 📂 [المشروع 1: نظام القائمة المتصلة المزدوجة الأساسي (Doubly Linked List)](https://github.com/ammmrrr18-cloud/Programming-Foundations-Roadmap/blob/main/13%20-%20Algorithms%20%26%20Problem%20Solving%20Level%205/Project%201/Extension%208(%20%20%20MydblLinkedList.InsertAfter%20(int%20index%2C%20T%20Value%20)%20%20)/Teacher-Soution/clsDblLinkedList.h)
* **الفكرة:** بناء هيكل العقدة العام ثنائي الاتجاه حيث تمتلك العناصر وعياً متزامناً بالعنصر السابق والتالي.
* **الهيكلية البرمجية:** التحكم المباشر بالمؤشرات الخام (`Next` و `Prev`)، ومزامنة العقد ديناميكياً، وإدارة حدود الذاكرة العشوائية يدوياً.

### 📂 [المشروع 2: طابور مخصص عبر تركيب القائمة (Queue via List Composition)](https://github.com/ammmrrr18-cloud/Programming-Foundations-Roadmap/blob/main/13%20-%20Algorithms%20%26%20Problem%20Solving%20Level%205/Project%202/Extension%201%20to%207%20(%20GetItem(int%20index)%20%2C%20%20Reverse()%20%20%2C%20%20UpdateItem()%20%2C%20InsertAfter(%20)%20%2CInsertAtFront()%20%20%2C%20%20InsertAtBack()%20%20%2C%20Clear()%20%20)/Teacher-Solution/clsMyQueue.h)
* **الفكرة:** تصميم غلاف مخصص لطابور تقليدي يعتمد على آلية FIFO باستخدام قائمة متصلة كبنية تحتية.
* **الهيكلية البرمجية:** **نمط تصميم التركيب (Composition)**. عبر تضمين القائمة المتصلة كعنصر محمي داخلي، يتيح النظام واجهة عامة ونظيفة تحجب تعقيدات المؤشرات تماماً عن المطور النهائي.

### 📂 [المشروع 3: مكدس مخصص عبر توريث الطابور (Stack via Queue Inheritance)](https://github.com/ammmrrr18-cloud/Programming-Foundations-Roadmap/blob/main/13%20-%20Algorithms%20%26%20Problem%20Solving%20Level%205/Project%203/Teacher-Solution/clsMyStack.h)
* **الفكرة:** تحوير هيكلية الطابور الخطي المشيد سابقاً ليعمل كمكدس صارم يتبع آلية LIFO.
* **الهيكلية البرمجية:** **التوريث الصريح وعمل الـ Overriding**. نظراً لتطابق الخصائص والوظائف الداخلية، تم اختيار التوريث وعمل Override لدالة الـ `push` للإدخال في المقدمة بدلاف من الكومبيزشن لتجنب تكرار الكود، وهو الحل الهندسي الأمثل. مع استخدام المؤشر الصريح `this->` لفك تداخل أسماء قوالب تعدد الأشكال أثناء الترجمة.

### 📂 [المشروع 4: المحرك العام للمصفوفة الديناميكية (Dynamic Array Engine)](https://github.com/ammmrrr18-cloud/Programming-Foundations-Roadmap/blob/main/13%20-%20Algorithms%20%26%20Problem%20Solving%20Level%205/Project%204/%20%20Extension%2011%20to%2014/My-Solution/clsDynamicArray.h)
* **الفكرة:** بناء مصفوفة ديناميكية مخصصة بالكامل تحاكي الـ Vector، ولها القدرة على التوسع والانكماش التلقائي في الذاكرة.
* **الهيكلية البرمجية:** إدارة حجز الذاكرة المستمرة على الـ Heap باستعمال المعاملين `new[]` و `delete[]` يدوياً، مع فرض قيود فحص الحدود الرقمية للأدلة، وبناء حلقات الإزاحة أثناء الإدخال والحذف.

### 📂 [المشروع 5: طابور مخصص مبني على المصفوفة الديناميكية (Queue via Array)](https://github.com/ammmrrr18-cloud/Programming-Foundations-Roadmap/blob/main/13%20-%20Algorithms%20%26%20Problem%20Solving%20Level%205/Project%205/clsMyQueueArr.h)
* **الفكرة:** الربط والتوفيق بين كفاءة حجز الذاكرة المتسلسلة والمستمرة للمصفوفات وبين منطق طوابير الـ FIFO.
* **الهيكلية البرمجية:** **مبدأ التركيب (Composition)**. تغليف المصفوفة الديناميكية داخلياً لحجب كلفة إعادة ترحيل الذاكرة، وتقديم دالات وصول آمنة ومفحوصة الحدود لمقدمة ومؤخرة الطابور.

### 📂 [المشروع 6: مكدس مخصص عبر توريث الطابور المصفوفي (Stack via Array-Queue)](https://github.com/ammmrrr18-cloud/Programming-Foundations-Roadmap/blob/main/13%20-%20Algorithms%20%26%20Problem%20Solving%20Level%205/Project%206/clsMyStackArr.h)
* **الفكرة:** تكييف الطابور المعتمد على المصفوفة المتسلسلة ليخدم وظائف المكدس الصارمة (LIFO).
* **الهيكلية البرمجية:** **التوريث العام وتعدد الأشكال**. إعادة استخدام بنية الطابور المصفوفي بالكامل وعمل **Override** لدالة الإضافة باستخدام المؤشر السياقي `this->` لتأمين عدم تكرار الدوال والمقاييس المتطابقة كالحجم والسعة.

### 📂 [المشروع 7: نظام إدارة النصوص الذكي وتتبع العمليات (Undo/Redo String)](https://github.com/ammmrrr18-cloud/Programming-Foundations-Roadmap/blob/main/13%20-%20Algorithms%20%26%20Problem%20Solving%20Level%205/Project%207(Undo%20%26%26%20Redo)/clsMyString.h)
* **الفكرة:** تشييد كلاس نصوص متطور يمتلك القدرة على التراجع والتقدم اللانهائي عبر خط الزمن الخاص بالعمليات.
* **الهيكلية البرمجية:** **إطار العمل القائم على المكدس المزدوج (Dual-Stack)**. توظيف التفاعل التبادلي الآمن بين مكدسي التراجع والإعادة لنقل لقطات البيانات (Snapshots) لحظياً، مغلفة داخل دالات وصول ذكية لحماية النص من التغيير العشوائي.

### 📂 [المشروع 8: نظام المحاكاة البرمجية لطوابير الانتظار البنكية (Queue Line System)](https://github.com/ammmrrr18-cloud/Programming-Foundations-Roadmap/blob/main/13%20-%20Algorithms%20%26%20Problem%20Solving%20Level%205/Project%208/Teacher-Solution/clsQueueLine.h)
* **الفكرة:** محرك محاكاة تفاعلي لتنظيم العملاء داخل مراكز الخدمة وحساب مؤشرات الانتظار المتوقعة.
* **الهيكلية البرمجية:** **تطبيق نمط الكلاسات المتداخلة (Nested Class)** عبر دمج كلاس التذكرة (`clsTicket`) داخلياً لعزل النطاق، مع توظيف استراتيجيات العرض غير المدمرة للبيانات عن طريق النسخ المؤقت للحاويات أثناء عمليات العرض والطباعة الاتجاهية.

---

## 🎯 المكتسبات والأهداف الهندسية المحققة

إتمام هذا الكورس المتقدم يضمن للمطور التمكن الكامل من المفاهيم المعمارية التالية:
1. **توسيع الأنظمة بأمان:** هندسة بنى برمجية قابلة لإضافة مميزات جديدة (Feature Growth) دون كسر الأنظمة القديمة.
2. **إدارة المتمتطلبات المتغيرة:** معالجة تزايد حجم المتطلبات وشروط الصيانة مع الحفاظ على التحكم المطلق بمسار التنفيذ والمنطق الرياضي.
3. **التطبيق الطبيعي لتراكيب البيانات:** توظيف الحاويات المناسبة لحل مشكلات واقعية ومعقدة بناءً على كفاءة الذاكرة ومقياس Big O.

---

## 🔮 الخطوة القادمة: الانتقال إلى الجزء الثاني (Part Two)

إنهاء هذا الكورس بنجاح يعطي الثقة التامة والجاهزية للانتقال إلى **الجزء الثاني من خارطة طريق البرمجة**، والذي يركز على بناء مهندسي الـ Backend الأقوياء القادرين على تصميم أنظمة تجارية حقيقية عبر تحولات بيئية مدروسة:
* **لغة البرمجة C#:** الانتقال إلى لغة برمجية حديثة وقوية واسعة الاستخدام في الشركات الكبرى.
* **احتراف قواعد البيانات:** دراسة 4 كورسات كاملة وعميقة ومكثفة لقواعد البيانات برمجياً وعملياً.
* **المرونة والاستقلالية للمطور:** اكتساب القدرة على التنقل بسهولة مطلقة بين التخصصات والمجالات المختلفة (ويب، باك اند، ديسكتوب، أو أي تقنية مستقبلية) دون التقيد بأداة واحدة، فالأساس القوي يمنح حرية الحركة المطلقة.

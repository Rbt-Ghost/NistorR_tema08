# Întrebări și Răspunsuri – Iluminare în OpenGL

---

## **1. Diferențele dintre iluminarea reală și modelul de iluminare OpenGL**

În lumea reală, iluminarea este un proces fizic complex care include reflexii multiple, lumină indirectă, umbre naturale, refracție și scattering, toate influențate de proprietățile microscopice ale suprafețelor; în schimb, OpenGL folosește un model de iluminare simplificat (Phong/Blinn-Phong) care calculează doar interacțiunea locală dintre lumină și obiect prin componente ambient, difuz și specular, fără lumină indirectă, umbre reale sau efecte fizice avansate.

---

## **2. Numărul de surse de lumină suportate în OpenGL (OpenTK)**

Modelul clasic de iluminare al OpenGL, așa cum este expus și prin framework-ul OpenTK, suportă maximum **8 surse de lumină** (`GL_LIGHT0` – `GL_LIGHT7`), aceasta fiind o limitare a pipeline-ului fix și nemodificată de OpenTK, care doar oferă acces la funcțiile OpenGL.

---

## **3. Definiția iluminării de material și utilizarea ei**

Iluminarea de material reprezintă proprietățile optice ale unui obiect (ambient, difuz, specular, emisiv și luciu) care determină modul în care acesta reflectă lumina în modelul de iluminare OpenGL, fiind utilizată la randarea obiectelor pentru a simula diverse tipuri de suprafețe precum metal, plastic, lemn sau materiale lucioase ori mate, influențând aspectul final al obiectului în funcție de lumina existentă în scenă.

---

## **4. Efectul activării unei surse de lumină secundare**

Activarea unei surse de lumină secundare determină o iluminare mai uniformă a obiectelor, reducerea contrastelor puternice și apariția highlight-urilor din direcții multiple; obiectele devin vizibile mai bine din mai multe unghiuri, zonele anterior întunecate se luminează, iar dacă luminile au culori diferite, suprafețele pot căpăta tonuri mixate rezultate din combinarea contribuțiilor celor două surse.

---

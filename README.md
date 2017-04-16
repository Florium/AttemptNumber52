# AttemptNumber52

/-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-/
  
  This project is a realization of the algorithm of sorting developed by the author. 
  The implementation of this algorithm is that: 
  1. The pointer passes through the array starting from its first element until the element next to the element on which the pointer is located will be less than that on which the pointer stands. 
  2. Next are all the elements of the array, following the element on which the pointer is located, smaller than the one on which the pointer stands. 
  3. In the next step, there are such elements of the array that are to the left of the pointer, which are greater than each of those elements that we found in the previous step. 
  4. Swap these groups of elements. 
  
  Note: the source pointer on each cycle of the algorithm's operation, until it reaches the penultimate element, is not reset.
  Also, two tests are applied to the project to check the correctness of the sort function. 
  The sort function has two attributes at the input: an array and its length.
  The output value of the function is the sorted array.
  
  The project is distributed under the GNU General Public License v3.0 license, which allows the user to copy, modify and distribute programs, and ensure that users of all derived programs receive the above rights.
  
/-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-/

  Данный проект представляет собой реализацию разработанного авторм алгоритма сортировки. 
  Реализация данного алгоритма заключается в том, что: 
  1. Указатель проходит по массиву начиная с его первого элемента до того момента пока элемент, следующий после элемента на котором стоит указатель, не будет меньше того, на котором стоит указатель. 
  2. Далее находятся все элементы массива, следующие после элемента на котором стоит указатель, меньшие того, на котором стоит указатель. 
  3. На следующем шаге находятся такие элементы массива, стоящие слева от указателя, которые больше каждого из тех элементов, которые мы нашли на прошлом шаге. 
  4. Меняем местами эти группы элементов. 
  
  Примечание: исходный указатель на каждом цикле работы алгоритма, пока не достиг предпоследнего элемента, не сбрасывается.
  Также к проекту прилагаются два теста для проверки корректности работы функции сортировки. 
  Функция сортировки имеет на входе два атрибута: массив и его длина.
  Выходным значением функции является отсортированный массив.

  Проект распространяется по лицензии GNU General Public License v3.0, что позволяет предоставить пользователю права копировать, модифицировать и распространять программы, а также гарантировать, что и пользователи всех производных программ получат вышеперечисленные права. 

/-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-/

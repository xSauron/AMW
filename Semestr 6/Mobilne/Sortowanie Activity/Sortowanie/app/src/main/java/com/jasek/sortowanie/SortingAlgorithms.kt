package com.jasek.sortowanie

class SortingAlgorithms {
    companion object {
        fun bubbleSort(arr: IntArray) {
            val n = arr.size
            for (i in 0 until n - 1) {
                for (j in 0 until n - i - 1) {
                    if (arr[j] > arr[j + 1]) {
                        // swap arr[j] and arr[j+1]
                        val temp = arr[j]
                        arr[j] = arr[j + 1]
                        arr[j + 1] = temp
                    }
                }
            }
        }
        fun insertSort(arr: IntArray) {
            for (i in 1 until arr.size) {
                val key = arr[i]
                var j = i - 1
                while (j >= 0 && arr[j] > key) {
                    arr[j + 1] = arr[j]
                    j--
                }
                arr[j + 1] = key
            }
        }

        fun mergeSort(arr: IntArray, l: Int, r: Int) {
            if (l < r) {
                val m = (l + r) / 2
                mergeSort(arr, l, m)
                mergeSort(arr, m + 1, r)
                merge(arr, l, m, r)
            }
        }

        fun merge(arr: IntArray, l: Int, m: Int, r: Int) {
            val n1 = m - l + 1
            val n2 = r - m
            val L = IntArray(n1)
            val R = IntArray(n2)
            for (i in 0 until n1) {
                L[i] = arr[l + i]
            }
            for (j in 0 until n2) {
                R[j] = arr[m + 1 + j]
            }
            var i = 0
            var j = 0
            var k = l
            while (i < n1 && j < n2) {
                if (L[i] <= R[j]) {
                    arr[k] = L[i]
                    i++
                } else {
                    arr[k] = R[j]
                    j++
                }
                k++
            }
            while (i < n1) {
                arr[k] = L[i]
                i++
                k++
            }
            while (j < n2) {
                arr[k] = R[j]
                j++
                k++
            }
        }

        fun selectionSort(arr: IntArray) {
            for (i in 0 until arr.size - 1) {
                var minIndex = i
                for (j in i + 1 until arr.size) {
                    if (arr[j] < arr[minIndex]) {
                        minIndex = j
                    }
                }
                if (minIndex != i) {
                    val temp = arr[i]
                    arr[i] = arr[minIndex]
                    arr[minIndex] = temp
                }
            }
        }

        fun quickSort(arr: IntArray, low: Int, high: Int) {
            if (low < high) {
                val pi = partition(arr, low, high)
                quickSort(arr, low, pi - 1)
                quickSort(arr, pi + 1, high)
            }
        }

        fun partition(arr: IntArray, low: Int, high: Int): Int {
            val pivot = arr[high]
            var i = low - 1
            for (j in low until high) {
                if (arr[j] <= pivot) {
                    i++
                    val temp = arr[i]
                    arr[i] = arr[j]
                    arr[j] = temp
                }
            }
            val temp = arr[i + 1]
            arr[i + 1] = arr[high]
            arr[high] = temp
            return i + 1
        }

        fun getDescription(algorithmName: String): String {
            return when (algorithmName) {
                "bubbleSort" -> "Algorytm sortowania bąbelkowego porównuje sąsiednie elementy i zamienia je miejscami, jeśli są w niewłaściwej kolejności, aż lista zostanie posortowana."
                "insertSort" -> "Algorytm sortowania przez wstawianie polega na wstawianiu każdego elementu na jego właściwe miejsce w posortowanej już części listy."
                "mergeSort" -> "Algorytm sortowania przez scalanie polega na podziale listy na dwie posortowane części, a następnie scalaniu ich w jedną posortowaną listę."
                "selectionSort" -> "Algorytm sortowania przez wybór polega na wybieraniu najmniejszego elementu z listy i umieszczaniu go na początku."
                "quickSort" -> "Algorytm sortowania szybkiego polega na podziale listy na dwie części względem wybranej wartości, sortowaniu każdej z nich, a następnie scaleniu w jedną posortowaną listę."
                else -> ""
            }
        }
    }
}
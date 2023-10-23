package com.jasek.sortowanie

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import com.jasek.sortowanie.databinding.SortResultsBinding
import java.util.*

class SortResults : AppCompatActivity() {
    private lateinit var binding: SortResultsBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = SortResultsBinding.inflate(layoutInflater)
        setContentView(binding.root)

        val sortType = intent.getStringExtra("sortType")
        Log.d("SortResults", "Received sort type: $sortType")
        val inputArray = intent.getIntArrayExtra("inputArray") ?: intArrayOf()
        Log.d("SortResults", "Received input: ${Arrays.toString(inputArray)}")

        val descriptionTextView = binding.description
        // Sort input based on selected radio button
        when (sortType) {
            "bubbleSort"-> {
                SortingAlgorithms.bubbleSort(inputArray)
                descriptionTextView.text = SortingAlgorithms.getDescription("bubbleSort");
            }
            "insertSort" -> {
                SortingAlgorithms.insertSort(inputArray)
                descriptionTextView.text = SortingAlgorithms.getDescription("insertSort");
            }
            "mergeSort" -> {
                SortingAlgorithms.mergeSort(inputArray, 0, inputArray.size - 1)
                descriptionTextView.text = SortingAlgorithms.getDescription("mergeSort");
            }
            "selectionSort" -> {
                SortingAlgorithms.selectionSort(inputArray)
                descriptionTextView.text = SortingAlgorithms.getDescription("selectionSort");
            }
            "quickSort" -> {
                SortingAlgorithms.quickSort(inputArray, 0, inputArray.size - 1)
                descriptionTextView.text = SortingAlgorithms.getDescription("selectionSort");
            }
        }
        val output = inputArray.joinToString(", ")

        binding.output.text = output

    }
}
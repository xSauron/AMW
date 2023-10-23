package com.jasek.sortowanie

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import com.jasek.sortowanie.databinding.ActivityMainBinding
import android.widget.Toast

class MainActivity : AppCompatActivity() {
    private lateinit var binding: ActivityMainBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        binding = ActivityMainBinding.inflate(layoutInflater) //initializing the binding class
        setContentView(binding.root)

        //Toast
        val context = applicationContext
        val duration = Toast.LENGTH_SHORT
        var message :Toast

        // Get reference to radio group
        val radioGroup = binding.groupSort
        val descriptionTextView = binding.description

        // Set listener for radio group changes
        radioGroup.setOnCheckedChangeListener { group, checkedId ->
            // Sort input based on selected radio button
            when (checkedId) {
                binding.bubbleSort.id -> {
                    descriptionTextView.text = SortingAlgorithms.getDescription("bubbleSort");
                    message = Toast.makeText(context, "Wybrałeś sortowanie bąbelkowe", duration)
                    message.show()
                }
                binding.insertSort.id -> {
                    descriptionTextView.text = SortingAlgorithms.getDescription("insertSort");
                    message = Toast.makeText(context, "Wybrałeś sortowanie przez wstawianie", duration)
                    message.show()
                }
                binding.mergeSort.id -> {
                    descriptionTextView.text = SortingAlgorithms.getDescription("mergeSort");
                    message = Toast.makeText(context, "Wybrałeś sortowanie przez scalanie", duration)
                    message.show()
                }
                binding.selectionSort.id -> {
                    descriptionTextView.text = SortingAlgorithms.getDescription("selectionSort");
                    message = Toast.makeText(context, "Wybrałeś sortowanie przez wybór", duration)
                    message.show()
                }
                binding.quickSort.id -> {
                    descriptionTextView.text = SortingAlgorithms.getDescription("quickSort");
                    message = Toast.makeText(context, "Wybrałeś sortowanie szybkie", duration)
                    message.show()
                }
            }
        }


        fun goToSorted(){
            // Get the input array from user input
            val input = binding.input.text.toString()

            try {
                val inputArray = input.split(",").map { it.trim().toInt() }.toIntArray()
                if(inputArray.isEmpty()){
                    message = Toast.makeText(context, "Input the numbers first!", duration)
                    message.show()
                    return
                }
                val selectedId = radioGroup.checkedRadioButtonId
                // Get the sort type from user input
                val sortType = when (selectedId) {
                    binding.bubbleSort.id -> "bubbleSort"
                    binding.insertSort.id -> "insertSort"
                    binding.mergeSort.id -> "mergeSort"
                    binding.selectionSort.id -> "selectionSort"
                    binding.quickSort.id -> "quickSort"
                    else -> "" // Default case when no radio button is selected
                }

                // Start SortedValues activity with inputArray and sortType parameters
                val intent = Intent(this, SortResults::class.java)
                intent.putExtra("inputArray", inputArray)
                intent.putExtra("sortType", sortType)
                startActivity(intent)

            }catch (e: Exception) {
                message = Toast.makeText(context, "Wprowadzono błędne dane!", duration)
                message.show()
            }

        }

        val sortButton = binding.sortButton

        sortButton.setOnClickListener {
            // Check if any radio button is selected
            if (radioGroup.checkedRadioButtonId == -1) {
                // No radio button is selected
                message = Toast.makeText(context, "Wybierz algorytm sortowania!", duration)
                message.show()
            } else {
                // A radio button is selected
                goToSorted()
            }

        }

    }
}


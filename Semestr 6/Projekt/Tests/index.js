const { Builder, By, Key, until } = require('selenium-webdriver');
const assert = require('assert');
require('chromedriver');
const { Options } = require('selenium-webdriver/chrome');



async function verifySession() {
  const driver = await new Builder().forBrowser('chrome').build();
  try {
    await driver.get('https://todo.mistaken.pl/auth/login.php'); // Replace with your website's login URL

    // Fill in the email and password fields
    await driver.findElement(By.id('email')).sendKeys('xSauron@outlook.com');
    await driver.findElement(By.id('password')).sendKeys('zaq1@WSXcv');

    // Submit the form
    await driver.findElement(By.id('submit')).sendKeys(Key.RETURN);

    // Wait for the page to load after submitting the form
    await driver.wait(until.urlIs('https://todo.mistaken.pl/main/main.php'), 5000); // Replace with your website's dashboard URL

    // Check if the phpauth_session_cookie exists
    const cookie = await driver.manage().getCookie('phpauth_session_cookie');
    if (cookie) {
      console.log('Session cookie found');
    } else {
      console.log('Session cookie not found');
    }
  } finally {
    await driver.quit();
  }
}

async function verifyMonths() {

  let options = new Options();
  options.addArguments('--start-maximized');
  
  const driver = new Builder().forBrowser('chrome').setChromeOptions(options).build();

  //await driver.manage().window().setRect({ width: 1280, height: 720 });
  
  try {
    await driver.get('https://todo.mistaken.pl/auth/login.php'); // Replace with your website's login URL

    // Fill in the email and password fields
    await driver.findElement(By.id('email')).sendKeys('xSauron@outlook.com');
    await driver.findElement(By.id('password')).sendKeys('zaq1@WSXcv');
    await driver.findElement(By.id('submit')).sendKeys(Key.RETURN);

    await driver.get('https://todo.mistaken.pl/main/main.php');

    
    //const calendarIcon = await driver.findElement(By.css('li a i.fa-calendar-days'));
    //await calendarIcon.click();

    // Get all the day elements
    let days = await driver.findElements(By.css(".fc-day"));
    let daysInMonth = 0;

    let currentMonth = new Date().getMonth();
    let currentYear = new Date().getFullYear();

    // Verify each day is displayed correctly
    for (let i = 0; i < days.length; i++) {
      let day = days[i];
      let date = await day.getAttribute("data-date");
      let classes = await day.getAttribute("class");
      let role = await day.getAttribute("role");

      //console.log(role)

      if(role == "columnheader"){
        let expectedDay = "";
        switch (i % 7) {
          case 0:
            expectedDay = "Sun";
            break;
          case 1:
            expectedDay = "Mon";
            break;
          case 2:
            expectedDay = "Tue";
            break;
          case 3:
            expectedDay = "Wed";
            break;
          case 4:
            expectedDay = "Thu";
            break;
          case 5:
            expectedDay = "Fri";
            break;
          case 6:
            expectedDay = "Sat";
            break;
        }
        let actualDay = await day.getText();
        if (actualDay != expectedDay) {
          console.error(`Column header for day ${expectedDay} is NOT displayed correctly`);
        } else {
          console.log(`Column header for day ${expectedDay} is displayed correctly`);
        }
      }else if(role == "gridcell"){
        let dateObj = new Date(date);
        if (dateObj.getMonth() === currentMonth && dateObj.getFullYear() === currentYear) {
          daysInMonth++;
        }

        // Check if the date is valid (optional)
        let isValidDate = !isNaN(Date.parse(date));
        
        if (!isValidDate) {
          console.log(`Day ${date} is NOT a valid date`);
        }else{
          console.log(`Day ${date} is a valid date`);
        }
      }

    }
    if (daysInMonth === new Date(currentYear, currentMonth + 1, 0).getDate()) {
      console.log(`There are ${daysInMonth} days in the current month.`);
    } else {
      console.error(`Error: There are ${daysInMonth} days in the current month, but there should be ${new Date(currentYear, currentMonth + 1, 0).getDate()} days.`);
    }

  } catch (error) {
    console.error('Test failed:', error);
  }finally{
    driver.quit();
  }
};

verifyMonths();


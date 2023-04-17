const { Builder, By, Key, until } = require('selenium-webdriver');
require('chromedriver');

async function verifySession() {
  const driver = await new Builder().forBrowser('chrome').build();

  try {
    await driver.get('https://todo.mistaken.pl/auth/login.php'); // Replace with your website's login URL

    // Fill in the email and password fields
    await driver.findElement(By.id('email')).sendKeys('X');
    await driver.findElement(By.id('password')).sendKeys('X');

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

verifySession();
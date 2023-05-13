<template>
  <div class="bg-gray-800 min-h-screen flex items-center justify-center">
    <div class="max-w-md w-full bg-white p-8 rounded-lg shadow-lg">
      <form action="action_page.php" method="post">
        <div class="mb-4">
          <div class="mx-auto mb-6">
            <img src="img_avatar2.png" alt="Avatar" class="w-24 h-24 rounded-full border-4 border-gray-500">
          </div>
          <label for="uname" class="block text-gray-700 font-bold mb-2">Username</label>
          <input type="text" placeholder="Enter Username" name="uname" required class="w-full px-3 py-2 text-gray-700 border rounded-lg focus:outline-none focus:shadow-outline-blue focus:border-blue-500">
        </div>
        <div class="mb-6">
          <label for="psw" class="block text-gray-700 font-bold mb-2">Password</label>
          <input type="password" placeholder="Enter Password" name="psw" required class="w-full px-3 py-2 text-gray-700 border rounded-lg focus:outline-none focus:shadow-outline-blue focus:border-blue-500">
        </div>
        <div class="mb-6">
          <button type="submit" class="w-full bg-blue-500 hover:bg-blue-600 text-white font-bold py-2 px-4 rounded-lg focus:outline-none focus:shadow-outline-blue">
            Login
          </button>
          <div class="mt-4">
            <label> <input type="checkbox" checked="checked" name="remember" class="mr-2"> Remember me </label>
            <span class="ml-6 text-sm"><a href="#" class="text-blue-500 hover:text-blue-700">Forgot password?</a></span>
          </div>
        </div>
        <div class="flex items-center justify-between">
          <button type="button" class="text-gray-600 hover:text-gray-700 focus:outline-none">Cancel</button>
        </div>
      </form>
    </div>
  </div>
</template>

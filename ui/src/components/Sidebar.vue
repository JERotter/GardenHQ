<template>
  <div>
    <button class="text-gray-600 hover:text-gray-800 focus:outline-none" @click="showSidebar = !showSidebar">
      <i class="fas fa-bars"></i>
    </button>
    <aside class="bg-gray-200 text-gray-700 h-screen w-64 fixed top-0 left-0 transition-all duration-300" :class="{'-ml-64': !showSidebar}">
      <div class="flex items-center justify-center h-16 border-b border-gray-400">
        <h1 class="text-lg font-bold">Sidebar</h1>
      </div>
      <nav class="flex flex-col flex-grow px-4 py-4">
        <a href="#" class="hover:bg-gray-300 py-2 rounded-lg mb-2">
          <i class="fas fa-tachometer-alt mr-2"></i> Dashboard
        </a>
        <a href="#" class="hover:bg-gray-300 py-2 rounded-lg mb-2">
          <i class="fas fa-user mr-2"></i> Profile
        </a>
        <a href="#" class="hover:bg-gray-300 py-2 rounded-lg mb-2">
          <i class="fas fa-cog mr-2"></i> Settings
        </a>
      </nav>
    </aside>
  </div>
</template>

<script>
export default {
  data() {
    return {
      showSidebar: false
    };
  }
};
</script>

<style>
/* Add any custom styles here */
</style>
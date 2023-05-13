<template>
    <div class="flex h-screen bg-gray-100">
      <!-- Main content area -->
      <div class="flex flex-col flex-1 overflow-hidden">
        <!-- Top bar -->
        <header class="flex items-center justify-between px-6 py-4 bg-white border-b border-gray-200">
          <div>
            <h2 class="text-lg font-medium text-gray-800">{{ $route.meta.title }}</h2>
          </div>
          <div>
            <button
              class="flex items-center justify-center px-4 py-2 text-sm font-medium text-white bg-blue-500 rounded-md hover:bg-blue-600"
            >
              <i class="fas fa-plus-circle mr-2"></i>
              New
            </button>
          </div>
        </header>
        <!-- Page content -->
        <main class="flex-1 overflow-y-auto p-6">
          <div class="grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-3 gap-6">
            <div class="bg-white rounded-lg shadow-lg p-6">
              <h3 class="text-lg font-medium text-gray-800 mb-4">Box 1</h3>
              <p class="text-gray-600">
                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor
                incididunt ut labore et dolore magna aliqua.
              </p>
            </div>
            <div class="bg-white rounded-lg shadow-lg p-6">
              <h3 class="text-lg font-medium text-gray-800 mb-4">Box 2</h3>
              <p class="text-gray-600">
                Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex
                ea commodo consequat.
              </p>
            </div>
            <div class="bg-white rounded-lg shadow-lg p-6">
              <h3 class="text-lg font-medium text-gray-800 mb-4">Box 3</h3>
              <p class="text-gray-600">
                Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat
                nulla pariatur.
              </p>
            </div>
            <div class="bg-white rounded-lg shadow-lg p-6">
              <h3 class="text-lg font-medium text-gray-800 mb-4">Box 4</h3>
              <p class="text-gray-600">
                Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt
                mollit anim id est laborum.
              </p>
            </div>
            <div class="bg-white rounded-lg shadow-lg p-6">
              <h3 class="text-lg font-medium text-gray-800 mb-4">Box 5</h3>
              <p class="text-gray-600">
                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor
                incididunt ut labore et dolore magna aliqua.
              </p>
            </div>
            <div class="bg-white rounded-lg shadow-lg p-6">
              <h3 class="text-lg font-medium text-gray-800 mb-4">Box 6</h3>
              <p class="text-gray-600">
                Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex
                ea commodo consequat.
              </p>
            </div>
          </div>
        </main>
      </div>
    </div>
  </template>
  
  <script>
  export default {
    data() {
      return {
        showSidebar: true
      }
    }
  }
  </script>
  
  <style>
  @media (max-width: 767px) {
    .grid {
      grid-template-columns: 1fr;
    }
  }
  
  @media (min-width: 768px) and (max-width: 1023px) {
    .grid {
      grid-template-columns: repeat(2, 1fr);
    }
  }
  </style>
  
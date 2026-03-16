<template>

	<div class="layout">

		<Sidebar :collapsed="menuCollapsed"/>

		<div class="main">

			<Topbar @toggleMenu="toggleMenu"/>

			<div class="content">
				<router-view/>
			</div>

		</div>

	</div>

</template>

<script setup>

	import { ref } from 'vue'
	import Sidebar from '../components/Sidebar.vue'
	import Topbar from '../components/Topbar.vue'

	const menuCollapsed = ref(false)

	function toggleMenu(){
		menuCollapsed.value = !menuCollapsed.value
	}

</script>

<style scoped>

	.layout{
		display:flex;
	}

	.main{
		flex:1;
		display:flex;
		flex-direction:column;
	}

	.content{
		padding:30px;
	}

</style>
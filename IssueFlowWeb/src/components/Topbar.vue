<template>

	<div class="topbar">

		<div class="left">
			<button @click="$emit('toggleMenu')">☰</button>
			<span>IssueFlow</span>
		</div>

		<div class="right">
			<span>Admin</span>
			<button @click="logout">Logout</button>
		</div>

	</div>

</template>

<script setup>
	import router from '../router'

	function logout(){
		localStorage.removeItem('token')
		router.push('/')
	}
</script>

<style scoped>

	.topbar{
		height:60px;
		background:#111827;
		color:white;

		display:flex;
		align-items:center;
		justify-content:space-between;

		padding:0 20px;
	}

	button{
		margin-left:10px;
	}

</style>
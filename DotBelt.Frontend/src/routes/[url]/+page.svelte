<script lang="ts">
  import {page} from "$app/stores";
  import {SITE_NAME} from "$lib/constants";
  import {onMount} from "svelte";

  let { data: { post } } = $page;

  onMount(() => {
      console.log(post)
  })

</script>

<svelte:head>
  <title>{post.title} - {SITE_NAME} </title>
</svelte:head>

<div class="post-content-container container-fluid">
  <div class="post-title-section">
    <h1>{post.title}</h1>
  </div>

  <div class="post-content">
    {@html post.contentHtml}
  </div>

</div>

<script lang="ts">

    import {onDestroy, onMount, setContext} from "svelte";
    import Repeater from "$lib/EditorJS/repeater/index.svelte";

  let { content = $bindable() } = $props();

  let editor : any = undefined;

  setContext('EditorJS', getData);

  export async function getData() {
      return await editor.save();
  }

  onDestroy(() => {
      if(editor) {
          editor.destroy();

      }
  })

  onMount(async () => {
      const EditorJS = (await import('@editorjs/editorjs')).default ;
      const List = (await import('@editorjs/list')).default;
      const Header = (await import('@editorjs/header')).default;
      const Underline = (await import('@editorjs/underline')).default;
      const Table = (await import('@editorjs/table')).default;


      editor = new EditorJS({
          logLevel: 'ERROR',

          onChange: async (api, event) => {
              content = JSON.stringify(await getData(), undefined, 2);
          },

          /**
           * Id of Element that should contain the Editor
           */
          placeholder: 'Let`s write an awesome story!',

          holder: 'editor-js',

          data: JSON.parse(content),

          /**
           * Available Tools list.
           * Pass Tool's class or Settings object for each Tool you want to use
           */
          tools: {
              repeater: Repeater,
              table: Table,
              underline: Underline,
              list: {
                  class: List,
                  inlineToolbar: true,
                  config: {
                      defaultStyle: 'unordered'
                  }
              },
              header: {
                  class: Header,
                  shortcut: 'CMD+SHIFT+H',
              },


          },
      })
  })

</script>

<div class="editor-js" id="editor-js"></div>
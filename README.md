Shapes
```html
    <input type="text">
```

```css
    body {
        margin: 0;
        padding: 0;
    }
```

```php
    <?php phpinfo();?>
```
```
---cs
using MarkdownSharp;
using MarkdownSharp.Extensions.Mal;

Markdown mark = new Markdown();

// Short link for MAL - 
// http://myanimelist.net/people/413/Kitamura_Eri => mal://Kitamura_Eri
mark.AddExtension(new Articles()); 
mark.AddExtension(new Profile());

mark.Transform(text);
---cs
```

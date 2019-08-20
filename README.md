# kundex
dead simple static site "builder"

### About

Kundex is a simple, static site "builder". It takes html templates and pages and connects them together.

I use the term "builder" loosely, as this is not a static site generator like Jekyll or Hugo. It's really just to save me time and save me from inconsistencies in my website. Maybe I'll use it for something more one day.

### Running

Kundex expects two command line arguments:
1) html source path
2) destination path

The first command line argument is required, the second is optional. If the second isn't provided, then Kundex will create the website files in the same directory Kundex is being run from locally, in a folder named `kundex-out`.

### Configuration

If Kundex finds a config file in the same location you are running it from, it will use the details from this config file. However, command line arguments will take precedence. The config file must be named `.kundexconfig`.

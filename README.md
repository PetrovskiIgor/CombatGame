CombatGame
==========

Оваа игра е многу закон.


1. Опис на апликацијата
-----------------------

Оваа апликација е едноставна игра која симулира борење на двајца играчи. Идејата ја добивме од веќе постоечките игри од овој тип кои некогаш сме ги играле и ние. Па одлучивме сега ние да сме тие кои создаваат и им овозможуваат на корисниците многу забава и меѓусебен натпревар. 

Однапред се извинуваме на сите корисници кои ќе останат ненаспани поради оваа игра. :)

![alt tag](https://github.com/ProektVizuelno/CombatGame/blob/master/CombatGame/CombatGame/DavidPunchD.png)

2. Упатство за играње
----------------------

Играта е пријателски настроена кон корисникот и има едноставна навигација. На почетокот има почетен екран од кој може да се започне нова игра, да се видат опциите на играта или пак да се напушти истата. На едноставен начин преку вториот екран за опции може да се видат контролите со кои играат двајцата играчи или да се исклучи музиката што свири во позадина и звучните ефекти. Најзначајниот екран за корисниците е екранот во кој бираат со кој играч сакаат да се борат и овој избор се прави со контролите на играчите прикажани во екранот за опции, а крајниот избор се потврдува со ентер за двајцата играчи. На крај се отвора еранот во кој се врши целото дејствие и во кој играчите ги прикажуваат своите боречки способности. Играта е фер и ниту еден играч не е посилен од некој друг, сите ги имаат истите напади кои одземаат исто енергија и сите имаат точно по три магии. Победата целосно зависи од способностите на корисниците. Играта завршува кога еден од играчите победува, односно кога другиот играч нема повеќе сила да се натпреварува и во тој момент се отвора нов екран од кој може да се избере нова игра или пак да се напушти играта. 

3. Имплементација
-----------------

Целосната логика на играта се содржи во класите Player, Magic и frmFight. Секој играч е инстанца од класата Player која ги чува името, моменталнта локација, димензиите, енергијата и моменталната состојба на играчот. Таа го овозмжува движењето на играчот, менувањето на состојбата и исцртувањето. Класата Magic содржи податоци за специјалните напади на играчите. Во неа се чува името на магијата, енергијата која ја одзема и сликата со која е репрезентирана. Класата си има свои методи кои се грижат за нејзиното движење и исцртување. Класата frmFight се грижи за исцртување не целосниот екран. Таа ги организира објектите од претходните класи и врши интеракција помеѓу нив. Таа се справува со настаните кои предизвикуваат движење на играчите или појавување на магиите и ги повикува соодветните методи од класите. 
